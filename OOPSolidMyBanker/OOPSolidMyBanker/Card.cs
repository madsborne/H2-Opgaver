using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSolidMyBanker
{
    class Card
    {
        private string nameOfCardOwner;
        private string cardNumber;
        private string bankNumber;
        private string regNumber;
        private string preFix;
        private int expireDate;
        private int balance;

        private Random cardNumberGenRnd = new Random();
        private Random bankNumberGenRnd = new Random();


        public string NameOfCardOwner
        {
            get
            {
                return nameOfCardOwner;
            }
            set
            {
                nameOfCardOwner = value;
            }
        }
        public string CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public string BankNumber { get { return bankNumber; } set { bankNumber = value; } }
        public string RegNumber { get { return regNumber; } set { regNumber = value; } }
        public int ExpireDate { get { return expireDate; } set { expireDate = value; } }
        public int Balance { get { return balance; } set { balance = value; } }

        public Card(int cardType)
        {
            CardNumberGen(cardType);
            BankInfoMation();
        }

        /// <summary>
        /// 1 = VISA, 2 = Mastercard, 3 = Visa Electron, 4 = Maestro, 5 = Debitcard
        /// </summary>
        /// <param name="cardType"></param>
        public void CardNumberGen(int cardType)
        {
            int minValue = 1000;
            int maxValue = 9999;
            switch (cardType)
            {
                // Visa Card
                case 1:
                    CardNumber = $"4{cardNumberGenRnd.Next(000, 999).ToString()}";
                    preFix = CardNumber;
                    for (int i = 0; i < 3; i++)
                    {
                        CardNumber += $" {cardNumberGenRnd.Next(minValue, maxValue).ToString()}";
                    }
                    break;

                // MasterCard
                case 2:
                    Random masterCardPreFix = new Random();
                    CardNumber = masterCardPreFix.Next(51, 55).ToString();
                    CardNumber += masterCardPreFix.Next(0, 9).ToString();
                    CardNumber += masterCardPreFix.Next(0, 9).ToString();
                    preFix = CardNumber;
                    for (int i = 0; i < 3; i++)
                    {
                        CardNumber += $" {cardNumberGenRnd.Next(minValue, maxValue).ToString()}";
                    }
                    break;

                // Visa Electron
                case 3:
                    int randomPickedPrefixElectron;
                    Random visaEletronPreFix = new Random();
                    string[] visaElectronPreFixs = new string[] { "4026", "4175 00", "4508", "4844", "4913", "4917" };
                    randomPickedPrefixElectron = visaEletronPreFix.Next(0, 5);

                    if (randomPickedPrefixElectron == 1)
                    {
                        CardNumber = visaElectronPreFixs[1];
                        CardNumber += visaEletronPreFix.Next(0, 9).ToString();
                        CardNumber += visaEletronPreFix.Next(0, 9).ToString();
                        preFix = CardNumber;
                        for (int i = 0; i < 2; i++)
                        {
                            CardNumber += $" {cardNumberGenRnd.Next(minValue, maxValue)}";
                        }
                    }
                    else
                    {
                        CardNumber = visaElectronPreFixs[randomPickedPrefixElectron];
                        preFix = CardNumber;
                        for (int i = 0; i < 3; i++)
                        {
                            CardNumber += $" {cardNumberGenRnd.Next(minValue, maxValue).ToString()}";
                        }
                    }
                    break;

                // Maestro Card
                case 4:
                    Random maestroPreFix = new Random();
                    string[] maestroPreFixs = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };

                    CardNumber = $"{maestroPreFixs[maestroPreFix.Next(0, 8)]}";
                    preFix = CardNumber;
                    for (int i = 0; i < 3; i++)
                    {
                        CardNumber += $" {cardNumberGenRnd.Next(10000, 99999).ToString()}";
                    }
                    break;

                // Debit Card
                case 5:
                    CardNumber = "2400";
                    preFix = CardNumber;
                    for (int i = 0; i < 3; i++)
                    {
                        CardNumber += $" {cardNumberGenRnd.Next(minValue, maxValue).ToString()}";
                    }
                    break;
            }
        }

        public void BankInfoMation()
        {
            BankNumber = "3520";
            for (int i = 0; i < 2; i++)
            {
                BankNumber += bankNumberGenRnd.Next(000000, 99999).ToString(); 
            }
        }

    }
}
