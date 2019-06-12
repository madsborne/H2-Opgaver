using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDragRacing
{
    class Car
    {
        // private fields
        private string carColor;
        private string carEngine;
        private double topSpeed;
        private double engineDelay;
        private int carId;

        // public attributes
        public string CarColor { get { return carColor; } set { carColor = value; } }
        public string CarEngine { get { return carEngine; } }
        public double TopSpeed { get { return topSpeed; } }
        public double EngineDelay { get { return engineDelay; } }
        public int CarId { get { return carId; } set { carId = value; } }

        // takes in 3 vars
        public Car(string selectedColor, int engineID, int idForCar)
        {
            // engineId is used to pick the engine the user wanted 
            EngineSelect(engineID);
            CarId = idForCar;
            CarColor = selectedColor;
        }

        /// <summary>
        /// has to types of engines 1 for Jonda - 2 for Poyota 
        /// </summary>
        /// <param name="userEngineID"></param>
        private void EngineSelect(int userEngineID)
        {
            switch (userEngineID)
            {
                case 1:
                    carEngine = "Jonda Engine";
                    topSpeed = 280;
                    engineDelay = 2.5;
                    break;

                case 2:
                    carEngine = "Poyota Engine";
                    topSpeed = 330;
                    engineDelay = 4;
                    break;
                
            }
        }
    }
}
