using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class Pitcher_base_cls : Player
    {
        //Normal Stats for Pitchers
        //Variables
        private int wins;
        private int loss;
        private decimal winPercentage;
        private decimal era;
        private int games;
        private int gamesStarted;
        private int gamesFinished;
        private int completeGames;
        private int shutOuts;
        private int saves;
        private decimal inningsPitched;
        private int hitsAllowed;
        private int runsAllowed;
        private int earnedRunsAllowed;
        private int homeRunsAllowed;
        private int basesOnBallsAllowed;
        private int intentionalBasesOnBalls;
        private int strikeOuts;
        private int hitByPitch;
        private int balks;
        private int wildPitches;
        private int battersFaced;
        private int eraPlus;
        private decimal fieldingIndependentPitching;
        private decimal whip;
        private decimal hitsDividedNineInnings;
        private decimal homeRunsDividedByNineInnings;
        private decimal walksDividedByNineInnings;
        private decimal strikeOutsDividedByNineInnings;
        private decimal strikeOutsDividedByWalks;

       

        public Pitcher_base_cls(int nWins, int nLoss, decimal nWinPercentage, decimal nERA, int nGames, int nGamesStarted, int nGamesFinished,
            int nCompleteGames, int nShutOuts, int nSaves, decimal nInningsPitched, int nHitsAllowed, int nRunsAllowed, int nEarnedRunsAllowed,
            int nHomeRunsAllowed, int nBasesOnBallsAllowed, int nIntentionalBasesOnBalls, int nStrikeOuts, int nHitsByPitch,
            int nBalks, int nWildPitches, int nBattersFaced, int nERAPlus, decimal nFieldingIndependentPitching, decimal nWhip,
            decimal nHitsDividedByNineInnings, decimal nWalksDividedByNineInnings, decimal nStrikeOutsDividedByNineInnings,
            decimal nStrikeOutsDividedByWalks,string nFirstName, string nLastName, string nPosition, DateTime nPlayerDob, 
            string nPlayerCity, string nPlayerTeam, int nAge) : base (nFirstName, nLastName, nPosition, nPlayerDob, nPlayerCity, nPlayerTeam, nAge)
        {
            wins = nWins;
            loss = nLoss;
            winPercentage = nWinPercentage;
            era = nERA;
            games = nGames;
            gamesStarted = nGamesStarted;
            gamesFinished = nGamesFinished;
            completeGames = nCompleteGames;
            shutOuts = nShutOuts;
            saves = nSaves;
            inningsPitched = nInningsPitched;
            hitsAllowed = nHitsAllowed;
            runsAllowed = nRunsAllowed;
            earnedRunsAllowed = nEarnedRunsAllowed;
            homeRunsAllowed = nHomeRunsAllowed;
            basesOnBallsAllowed = nBasesOnBallsAllowed;
            intentionalBasesOnBalls = nIntentionalBasesOnBalls;
            strikeOuts = nStrikeOuts;
            hitByPitch = nHitsByPitch;
            balks = nBalks;
            wildPitches = nWildPitches;
            battersFaced = nBattersFaced;
            eraPlus = nERAPlus;
            fieldingIndependentPitching = nFieldingIndependentPitching;
            whip = nWhip;
            hitsDividedNineInnings = nHitsDividedByNineInnings;
            walksDividedByNineInnings = nWalksDividedByNineInnings;
            strikeOutsDividedByNineInnings = nStrikeOutsDividedByNineInnings;
            strikeOutsDividedByWalks = nStrikeOutsDividedByWalks;
        }
        public int Wins
        {
            get 
            {
                return wins; 
            }
            set 
            { 
                wins = value; 
            }
        }
        public int Loss
        {
            get 
            { 
                return loss; 
            }
            set 
            { 
                loss = value; 
            }
        }
        public decimal WinPercentage
        {
            get 
            {
                return winPercentage; 
            }
            set 
            { 
                winPercentage = value; 
            }
        }
        public decimal Era
        {
            get 
            { 
                return era; 
            }
            set 
            { 
                era = value; 
            }
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
        public int GamesStarted
        {
            get 
            { 
                return gamesStarted; 
            }
            set 
            { 
                gamesStarted = value; 
            }
        }
        public int GamesFinished
        {
            get 
            { 
                return gamesFinished; 
            }
            set
            { 
                gamesFinished = value; 
            }
        }
        public int CompleteGames
        {
            get 
            { 
                return completeGames; 
            }
            set 
            { 
                completeGames = value; 
            }
        }
        public int ShutOuts
        {
            get 
            { 
                return shutOuts; 
            }
            set 
            { 
                shutOuts = value; 
            }
        }
        public int Saves
        {
            get 
            { 
                return saves; 
            }
            set 
            { 
                saves = value; 
            }
        }
        public decimal InningsPitched
        {
            get 
            { 
                return inningsPitched; 
            }
            set 
            { 
                inningsPitched = value; 
            }
        }
        public int HitsAllowed
        {
            get 
            { 
                return hitsAllowed; 
            }
            set 
            { 
                hitsAllowed = value;
            }
        }
        public int RunsAllowed
        {
            get 
            { 
                return runsAllowed; 
            }
            set 
            { 
                runsAllowed = value; 
            }
        }
        public int EarnedRunsAllowed
        {
            get 
            { 
                return earnedRunsAllowed; 
            }
            set 
            {
                earnedRunsAllowed = value; 
            }
        }
        public int HomeRunsAllowed
        {
            get 
            { 
                return homeRunsAllowed; 
            }
            set 
            { 
                homeRunsAllowed = value; 
            }
        }
        public int BasesOnBallsAllowed
        {
            get 
            { 
                return basesOnBallsAllowed; 
            }
            set
            { 
                basesOnBallsAllowed = value; 
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
        public int Balks
        {
            get 
            { 
                return balks; 
            }
            set 
            { 
                balks = value; 
            }
        }
        public int WildPitches
        {
            get 
            { 
                return wildPitches; 
            }
            set 
            { 
                wildPitches = value; 
            }
        }
        public int BattersFaced
        {
            get 
            { 
                return battersFaced; 
            }
            set 
            { 
                battersFaced = value; 
            }
        }
        public int EraPlus
        {
            get 
            { 
                return eraPlus; 
            }
            set
            { 
                eraPlus = value; 
            }
        }
        public decimal FieldingIndependentPitching
        {
            get 
            {
                return fieldingIndependentPitching; 
            }
            set 
            { 
                fieldingIndependentPitching = value; 
            }
        }
        public decimal Whip
        {
            get 
            { 
                return whip; 
            }
            set 
            { 
                whip = value; 
            }
        }
        public decimal HitsDividedNineInnings
        {
            get
            {
                return hitsDividedNineInnings; 
            }
            set 
            { 
                hitsDividedNineInnings = value; 
            }
        }
        public decimal HomeRunsDividedByNineInnings
        {
            get 
            {
                return homeRunsDividedByNineInnings; 
            }
            set 
            { 
                homeRunsDividedByNineInnings = value; 
            }
        }
        public decimal WalksDividedByNineInnings
        {
            get 
            { 
                return walksDividedByNineInnings; 
            }
            set
            { 
                walksDividedByNineInnings = value; 
            }
        }
        public decimal StrikeOutsDividedByNineInnings
        {
            get 
            { 
                return strikeOutsDividedByNineInnings; 
            }
            set
            {
                strikeOutsDividedByNineInnings = value;
            }
        }
        public decimal StrikeOutsDividedByWalks
        {
            get 
            {
                return strikeOutsDividedByWalks;
            }
            set 
            { 
                strikeOutsDividedByWalks = value; 
            }
        }
    }
}
