using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace WPF_Fishy
{
    class AnimalViewModel : INotifyPropertyChanged
    {
        private Animal currentAnimal;
        private ObservableCollection<Animal> animals = new ObservableCollection<Animal>();
        public ObservableCollection<Animal> Animals { get { return animals; } set { animals = value; } }
        public Animal CurrentAnimal { get { return currentAnimal; } set { currentAnimal = value; OnPropertyChanged(nameof(this.CurrentAnimal)); } }

        public AnimalViewModel()
        {
            animals.Add(new Animal("Clown Fish", "250 grams", "4 to 6 inches long", @"https://images-na.ssl-images-amazon.com/images/I/51-n8T7RAPL._SX569_.jpg"));
            animals.Add(new Animal("Hammerhead Shark", "3 to 580 kg (6.6 to 1,278.7 lb)", "0.9 to 6.0 m (3.0 to 19.7 ft)", @"https://media.mnn.com/assets/images/2016/06/hammerhead-shark.jpg.653x0_q80_crop-smart.jpg"));
            animals.Add(new Animal("Japanese sawshark", "grow to a weight of 18.7 pounds", "around 14 inches at birth to 38 inches in males and 44 inches in females", @"https://www.zoochat.com/community/media/japanese-sawshark.426005/full?d=1543076579"));
        }

        //delegate til event håndtering
        public event PropertyChangedEventHandler PropertyChanged;
        //det er denne metode der kaldes, når der skal kastes en event
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
