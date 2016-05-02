using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class Teams
    {
        //base constructor for teams.  Pretty sure more description about the team will need to be added as program develops.
        private string mascot;
        private string league;
        private string division;
        private string city;

        public Teams(string nMascot, string nLeague, string nDivision, string nCity)
        {
            mascot = nMascot;
            league = nLeague;
            division = nDivision;
            city = nCity;
        }
        public string Mascot
        {
            get
            {
                return mascot;
            }
            set
            {
                mascot = value;
            }
        }
        public string League
        {
            get
            {
                return league;
            }
            set
            {
                league = value;
            }
        }
        public string Division
        {
            get
            {
                return division;
            }
            set
            {
                division = value;
            }
        }

    }
}
