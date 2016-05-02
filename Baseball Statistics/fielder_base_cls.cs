using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class Fielder_base_cls : Player
    {
       //Class for standard stats for hitters.
        //Variables
        private int games;
        private int plateAppearnces;
        private int atBats;
        private int runs;
        private int hits;
        private int doubles;
        private int triples;
        private int homeRuns;
        private int runsBattedIn;
        private int stolenBases;
        private int caughtStealing;
        private int basesOnBalls;
        private int strikeOuts;
        private int battingAverage;
        private int onBasePercentage;
        private int sluggingPercentags;
        private int ops;
        private int opsPlus;
        private int totalBases;
        private int groundDoublePlays;
        private int hitByPitch;
        private int sacrificeHits;
        private int sacrificeFly;
        private int intentionalBasesOnBalls;
        
        public Fielder_base_cls(int ngames, int nplateAppearences, int nAtBats, int nRuns, int nHits, int nDoubles, int nTriples, int nHomeRuns, int nRunsBattedIn,
            int nStolenBases, int nCaughtStealing, int nBasesOnBalls, int nStrikeOuts, int nBattingAverage, int nOnBasePercentage, int nSluggingPercentage,
            int nOps, int nOpsPlus, int nTotalBases, int nGroundDoublePlays, int nHitByPitch, int nSacrificeFly, int nIntentionalBasesOnBalls,
            string nFirstName, string nLastName, string nPosition, DateTime nPlayerDob, string nPlayerCity, string nPlayerTeam, int nAge)
            : base(nFirstName, nLastName, nPosition, nPlayerDob, nPlayerCity, nPlayerTeam, nAge)

        {
            games = ngames;
            plateAppearnces = nplateAppearences;
            atBats = nAtBats;
            runs = nRuns;
            hits = nHits;
            doubles = nDoubles;
            triples = nTriples;
            homeRuns = nHomeRuns;
            runsBattedIn = nRunsBattedIn;
            stolenBases = nStolenBases;
            caughtStealing = nCaughtStealing;
            basesOnBalls = nBasesOnBalls;
            strikeOuts = nStrikeOuts;
            battingAverage = nBattingAverage;
            onBasePercentage = nOnBasePercentage;
            sluggingPercentags = nSluggingPercentage;
            ops = nOps;
            opsPlus = nOpsPlus;
            totalBases = nTotalBases;
            groundDoublePlays = nGroundDoublePlays;
            hitByPitch = nHitByPitch;
            sacrificeFly = nSacrificeFly;
            intentionalBasesOnBalls = nIntentionalBasesOnBalls;

        }

         public int Games
            {
                get 
                {
                    return games;
                }
                set
                {
                    games = value;
                }

            }
        public int PlateAppearnces
        {
            get
            {
                return plateAppearnces;
            }
            set
            {
                plateAppearnces = value;
            }
        }
        public int AtBats
        {
            get
            {
                return atBats;
            }
            set
            {
                atBats = value;
            }
        }
        public int Hits
        {
            get
            {
                return hits;
            }
            set
            {
                hits = value;
            }
        }
        public int Doubles
        {
            get 
            {
                return doubles;
            }
            set
            {
                doubles = value;
            }
        }
        public int Triples
        {
            get
            {
                return triples;
            }
            set
            {
                triples = value;
            }
        }
        public int HomeRuns
        {
            get
            {
                return homeRuns;
            }
            set
            {
                homeRuns = value;
            }
        }
        public int RunsBattedIn
        {
            get
            {
                return runsBattedIn;
            }
            set
            {
                runsBattedIn = value;
            }
        }
        public int StolenBases
        {
            get
            {
                return stolenBases;
            }
            set
            {
                stolenBases = value;
            }
        }
        public int CaughtStealing
        {
            get
            {
                return caughtStealing;
            }
            set
            {
                caughtStealing = value;
            }
        }
        public int BasesOnBalls
        {
            get
            {
                return basesOnBalls;
            }
            set
            {
                basesOnBalls = value;
            }
        }
        public int StrikeOuts
        {
            get
            {
                return strikeOuts;
            }
            set
            {
                strikeOuts = value;
            }
        }
        public int BattingAverage
        {
            get
            {
                return battingAverage;
            }
            set
            {
                battingAverage = value;
            }
        }
        public int OnBasePercentage
        {
            get
            {
                return onBasePercentage;
            }
            set
            {
                onBasePercentage = value;
            }
        }
        public int SluggingPercentage
        {
            get
            {
                return sluggingPercentags;
            }
            set
            {
                sluggingPercentags = value;
            }
        }
        public int OPS
        {
            get
            {
                return ops;
            }
            set
            {
                ops = value;
            }
        }
        public int OpsPlus
        {
            get
            {
                return opsPlus;
            }
            set
            {
                opsPlus = value;
            }
        }
        public int TotalBases
        {
            get
            {
                return totalBases;
            }
            set
            {
                totalBases = value;
            }
        }
        public int GroundDoublePlays
        {
            get
            {
                return groundDoublePlays;
            }
            set
            {
                groundDoublePlays = value;
            }
        }
        public int HitByPitch
        {
            get
            {
                return hitByPitch;
            }
            set
            {
                hitByPitch = value;
            }
        }
       public int SacrificeFly
       {
           get
           {
               return sacrificeFly;
           }
           set
           {
               sacrificeFly = value;
           }
       }
        
        public int IntentionalBasesOnBalls
        {
            get
            {
                return intentionalBasesOnBalls;
            }
            set
            {
                intentionalBasesOnBalls = value;
            }
        }
        public Fielder_base_cls() : base()
        {

        }

    }
       
  }


