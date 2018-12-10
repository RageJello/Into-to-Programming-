using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketFinal
{
    class RocketClass
    {
        // Members
        private string rocket;
        public string rocketName;
        public string rocketManufacturer;
        public string rocketStatus;
        public string rocketLastLaunch;
        public string[][] rockets =
        {
            new string[] {"Atlas III", "Lockheed Martin", "Retired", "February 3, 2005"},
            new string[] {"Minotaur II", "Orbital Sciences", "Active", "September 24, 2008"},
            new string[] {"Atlas V", "United Launch Alliance", "Active", "October 17, 2018"},
            new string[] {"Delta IV", "United Launch Alliance", "Active", "August 12, 2018"},
            new string[] {"Minotaur I", "Northrop Grumman", "Active", "November 20, 2013"},
            new string[] {"Minotaur IV", "Northrop Grumman", "Active", "August 26, 2017"},
            new string[] {"Falcon 1", "Retired", "SpaceX", "July 14, 2009"},
            new string[] {"Falcon 9", "Active", "SpaceX", "December 5, 2018"},
            new string[] {"Antares", "Northrop Grumman", "Development (230 series)", "October 17, 2016"},
            new string[] {"Falcon Heavy", "SpaceX", "Active", "February 6, 2018"}
        };

        
        public string LaunchRocketName(int rocketNumber)
        {
            rocketName = rockets[rocketNumber][0].ToString();
            return rocketName;
        }

        public string LaunchRocketManufacturer(int rocketNumber)
        {
            rocketManufacturer = rockets[rocketNumber][1].ToString();
            return rocketManufacturer;
        }

        public string LaunchRocketStatus(int rocketNumber)
        {
            rocketStatus = rockets[rocketNumber][2].ToString();
            return rocketStatus;
        }

        public string LaunchRocketLastLaunch(int rocketNumber)
        {
            rocketLastLaunch = rockets[rocketNumber][3].ToString();
            return rocketLastLaunch;
        }
    }
}
