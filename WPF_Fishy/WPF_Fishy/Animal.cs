using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Fishy
{
    class Animal
    {
        private string name;
        private string weight;
        private string lenght;
        private string imageSource;

        public string Name { get { return name; } set { name = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string Lenght { get { return lenght; } set { lenght = value; } }
        public string ImageSource { get { return imageSource; } set { imageSource = value; } }

        public Animal(string animalName, string animalWeight, string animalLenght, string animalImage)
        {
            Name = animalName;
            Weight = animalWeight;
            Lenght = animalLenght;
            ImageSource = animalImage;
        }
    }
}
