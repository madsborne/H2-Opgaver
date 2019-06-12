using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDragRacing
{
    class RaceTrack
    {
        // private fields
        private double raceTrackLenghtPlayer = 400;
        private double raceTrackLenghtAI = 400;
        private double playerRaceTime = 0;
        private double aiRaceTime = 0;
        // creates two cars 
        Car playerCar;
        Car aiCar;

        // takes in two vars and instances the two cars
        public RaceTrack(string userPickedColor, int userPickedEngine)
        {
            playerCar = new Car(userPickedColor, userPickedEngine, 1);
            aiCar = new Car("yellow", 1, 2);
        }

        /// <summary>
        /// starts the race and cal who wins
        /// </summary>
        /// <returns></returns>
        public string StartRace()
        {
            // creates the player racetime
            if (playerCar.EngineDelay == 2.5)
            {
                raceTrackLenghtPlayer = raceTrackLenghtPlayer - 50;
                playerRaceTime = Convert.ToDouble(raceTrackLenghtPlayer / playerCar.TopSpeed);
            }
            else
            {
                raceTrackLenghtPlayer = raceTrackLenghtPlayer - 100;
                playerRaceTime = Convert.ToDouble(raceTrackLenghtPlayer / playerCar.TopSpeed);
            }

            // creates the ai racetime
            if (aiCar.EngineDelay == 2.5)
            {
                raceTrackLenghtAI = raceTrackLenghtAI - 50;
                aiRaceTime = Convert.ToDouble(raceTrackLenghtAI / playerCar.TopSpeed);
            }
            else
            {
                raceTrackLenghtAI = raceTrackLenghtAI - 100;
                aiRaceTime = Convert.ToDouble(raceTrackLenghtAI / playerCar.TopSpeed);
            }

            // checks to see who won and returns the result
            if (playerRaceTime < aiRaceTime)
            {
                return $"Player Won your time -> {string.Format("{0:0.00}", playerRaceTime)} Ai lost Ais time -> {string.Format("{0:0.00}", aiRaceTime)}";
            }
            else if (playerRaceTime == aiRaceTime)
            {
                return  $"Draw Player your time -> {string.Format("{0:0.00}", playerRaceTime)} Ai time -> {string.Format("{0:0.00}", aiRaceTime)}";
            }
            else
            {
                return $"Player lost your time -> {string.Format("{0:0.00}", playerRaceTime)} Ai won ais time -> {string.Format("{0:0.00}", aiRaceTime)}";
            }

        }
    }
}
