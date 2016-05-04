using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class Fielding: Player 
    {
        private int games;
        private int gamesStarted;
        private int completeGames;
        private decimal innings;
        private int defensiveChances;
        private int putOuts;
        private int assists;
        private int errors;
        private int doublePlaysTurned;
        private decimal fieldingPercentage;
        private int totalZone;
        private int totalZoneYear;
        private int runsSavedAboveAvg;
        private int runsSavedAboveAvg1200;
        private decimal rangeFactorPer9;
        private decimal rangeFactorPerGame;
        private int passedBalls;
        private int wildPitches;
        private int stolenBases;
        private int caughtStealing;
        private decimal caughtStealingPerc;
        private decimal leagueCaughtStealingPerc;
        private int pickOffs;
        private string positionSummary;

        

        public Fielding(int nGames, int nGamesStarted, int nCompletedGames, decimal nInnings, int nDefensiveChances, int nPutOuts, int nAssists, int nErrors,
            int nDoublePlaysTurned, decimal nFieldingPercentage, int nTotalZone, int nTotalZoneYear, int nRunsSavedAboveAvg, int nRunsSavedAboveAvg1200,
            decimal nRangeFactorPer9, decimal nRangeFactorPerGame, int nPassedBalls, int nWildPitches, int nStolenBases, int nCaughtStealing, decimal nCaughtStealingPerc,
            decimal nLeagueCaughtStealingPerc, int nPickOffs, string nPositionSummary, string nFirstName, string nLastName, string nPosition, DateTime nPlayerDob,
            string nPlayerCity, string nPlayerTeam, int nAge) : base(nFirstName, nLastName, nPosition, nPlayerDob, nPlayerCity, nPlayerTeam, nAge)
        {
            games = nGames;
            gamesStarted = nGamesStarted;
            completeGames = nCompletedGames;
            innings = nInnings;
            defensiveChances = nDefensiveChances;
            putOuts = nPutOuts;
            assists = nAssists;
            errors = nErrors;
            doublePlaysTurned = nDoublePlaysTurned;
            fieldingPercentage = nFieldingPercentage;
            totalZone = nTotalZone;
            totalZoneYear = nTotalZoneYear;
            runsSavedAboveAvg = nRunsSavedAboveAvg;
            runsSavedAboveAvg1200 = nRunsSavedAboveAvg1200;
            rangeFactorPer9 = nRangeFactorPer9;
            rangeFactorPerGame = nRangeFactorPerGame;
            passedBalls = nPassedBalls;
            wildPitches = nWildPitches;
            stolenBases = nStolenBases;
            caughtStealing = nCaughtStealing;
            caughtStealingPerc = nCaughtStealingPerc;
            leagueCaughtStealingPerc = nLeagueCaughtStealingPerc;
            pickOffs = nPickOffs;
            positionSummary = nPositionSummary;
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
        public decimal Innings
        {
            get 
            { 
                return innings;
            }
            set
            {
                innings = value; 
            }
        }
        public int DefensiveChances
        {
            get 
            {
                return defensiveChances; 
            }
            set 
            { 
                defensiveChances = value; 
            }
        }
        public int PutOuts
        {
            get
            { 
                return putOuts;
            }
            set
            { 
                putOuts = value;
            }
        }
        public int Assists
        {
            get 
            { 
                return assists;
            }
            set 
            { 
                assists = value; 
            }
        }
        public int Errors
        {
            get 
            {
                return errors; 
            }
            set
            {
                errors = value; 
            }
        }
        public int DoublePlaysTurned
        {
            get 
            { 
                return doublePlaysTurned;
            }
            set
            { 
                doublePlaysTurned = value; 
            }
        }
        public decimal FieldingPercentage
        {
            get 
            { 
                return fieldingPercentage; 
            }
            set 
            { 
                fieldingPercentage = value; 
            }
        }
        public int TotalZone
        {
            get 
            { 
                return totalZone;
            }
            set 
            { 
                totalZone = value; 
            }
        }
        public int TotalZoneYear
        {
            get 
            {
                return totalZoneYear; 
            }
            set 
            { 
                totalZoneYear = value; 
            }
        }
        public int RunsSavedAboveAvg
        {
            get 
            { 
                return runsSavedAboveAvg; 
            }
            set 
            { 
                runsSavedAboveAvg = value; 
            }
        }
        public int RunsSavedAboveAvg1200
        {
            get 
            { 
                return runsSavedAboveAvg1200; 
            }
            set
            { 
                runsSavedAboveAvg1200 = value; 
            }
        }
        public decimal RangeFactorPer9
        {
            get 
            { 
                return rangeFactorPer9; 
            }
            set 
            { 
                rangeFactorPer9 = value;
            }
        }
        public decimal RangeFactorPerGame
        {
            get 
            { 
                return rangeFactorPerGame;
            }
            set 
            { 
                rangeFactorPerGame = value; 
            }
        }
        public int PassedBalls
        {
            get 
            { 
                return passedBalls;
            }
            set 
            { 
                passedBalls = value;
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
        public decimal CaughtStealingPerc
        {
            get
            {
                return caughtStealingPerc; 
            }
            set
            { 
                caughtStealingPerc = value; 
            }
        }
        public decimal LeagueCaughtStealingPerc
        {
            get 
            { 
                return leagueCaughtStealingPerc; 
            }
            set 
            { 
                leagueCaughtStealingPerc = value; 
            }
        }
        public int PickOffs
        {
            get 
            { 
                return pickOffs; 
            }
            set 
            { 
                pickOffs = value; 
            }
        }
        public string PositionSummary
        {
            get 
            { 
                return positionSummary;
            }
            set 
            { 
                positionSummary = value; 
            }
        }
    }
}
