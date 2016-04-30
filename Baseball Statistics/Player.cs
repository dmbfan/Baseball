using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class Player
    {
        //creating base class for just normal player to inherit into for other classes.
        //Don't believe I will need any more info to construct at this time.
        private string firstName;        
        private string lastName;
        private string position;
        private DateTime playerDob;
        private string playerCity;
        private string playerTeam;
        //constructor
        public Player(string nFirstName, string nLastName, string nPosition, DateTime nPlayerDob, string nPlayerCity, string nPlayerTeam)
        {
            firstName = nFirstName;
            lastName = nLastName;
            position = nPosition;
            playerDob = nPlayerDob;
            playerCity = nPlayerCity;
            playerTeam = nPlayerTeam;
        }
        //properties
        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            set 
            { 
                firstName = value; 
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        public DateTime PlayerDob
        {
            get
            {
                return playerDob;
            }
            set
            {
                playerDob = value;
            }
        }
        public string PlayerCity
        {
            get
            {
                return playerCity;
            }
            set
            {
                playerCity = value;
            }
        }
        public string PlayerTeam
        {
            get
            {
                return playerTeam;
            }
            set
            {
                playerTeam = value;
            }
        }

    }
}
