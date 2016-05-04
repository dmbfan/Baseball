using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Statistics
{
    class BatterValue: Player
    {
        private int games;
        private int plateAppearences;
        private int runsBatting;
        private int runsFromBaseRunning;
        private int runsGrndDoublePlay;
        private int runsFromFielding;
        private int runsFromPosScarcity;
        private int runsBetterThanAvg;
        private decimal winsAboveAvg;
        private int runsFromReplacement;
        private int runsAboveReplacement;
        private decimal winsAboveReplacement;
        private decimal winLossWithAvgTeamPer;
        private decimal winLossWithAvgTeamSeason;
        private decimal offensiveWAR;
        private decimal deffensiveWAR;
        private int offensiveRunsAboveReplacment;
        private int salary;
        private string acquired;
        private string posSummary;

        

        public BatterValue(int nGames, int nPlateAppearnences, int nRunsBatting, int nRunsFromBaseRunning, int nRunsGrndDoublePlay, int nRunsFromFielding,
            int nRunsFromPosScarcity, int nRunsBetterThanAvg, decimal nWinsAboveAvg, int nRunsFromReplacement, int nRunsAboveReplacement,
            decimal nWinsAboveReplacement, decimal nWinLossWithAvgTeamPer, decimal nWingLossWithAvgTeamSeason, decimal nOffensiveWAR, decimal nDefensiveWAR, int nOffensiveRunsAboveReplacement,
            int nSalary, string nAcquired, string nPosSummary, string nFirstName, string nLastName, string nPosition, DateTime nPlayerDob, string nPlayerCity, 
            string nPlayerTeam, int nAge): base(nFirstName, nLastName, nPosition, nPlayerDob, nPlayerCity, nPlayerTeam, nAge)
        {
            games = nGames;
            plateAppearences = nPlateAppearnences;
            runsBatting = nRunsBatting;
            runsFromBaseRunning = nRunsFromBaseRunning;
            runsGrndDoublePlay = nRunsGrndDoublePlay;
            runsFromFielding = nRunsFromFielding;
            runsFromPosScarcity = nRunsFromPosScarcity;
            runsBetterThanAvg = nRunsBetterThanAvg;
            winsAboveAvg = nWinsAboveAvg;
            runsFromReplacement = nRunsFromReplacement;
            runsAboveReplacement = nRunsAboveReplacement;
            winsAboveReplacement = nWinsAboveReplacement;
            winLossWithAvgTeamPer = nWinLossWithAvgTeamPer;
            winLossWithAvgTeamSeason = nWingLossWithAvgTeamSeason;
            offensiveWAR = nOffensiveWAR;
            deffensiveWAR = nDefensiveWAR;
            offensiveRunsAboveReplacment = nOffensiveRunsAboveReplacement;
            salary = nSalary;
            acquired = nAcquired;
            posSummary = nPosSummary;

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
        public int PlateAppearences
        {
            get 
            { 
                return plateAppearences; 
            }
            set 
            { 
                plateAppearences = value; 
            }
        }
        public int RunsBatting
        {
            get 
            { 
                return runsBatting; 
            }
            set 
            {
                runsBatting = value;
            }
        }
        public int RunsFromBaseRunning
        {
            get
            { 
                return runsFromBaseRunning; 
            }
            set 
            { 
                runsFromBaseRunning = value;
            }
        }
        public int RunsGrndDoublePlay
        {
            get 
            { 
                return runsGrndDoublePlay; 
            }
            set 
            {
                runsGrndDoublePlay = value; 
            }
        }
        public int RunsFromFielding
        {
            get 
            { 
                return runsFromFielding; 
            }
            set 
            { 
                runsFromFielding = value; 
            }
        }
        public int RunsFromPosScarcity
        {
            get 
            { 
                return runsFromPosScarcity; 
            }
            set 
            { 
                runsFromPosScarcity = value; 
            }
        }
        public int RunsBetterThanAvg
        {
            get 
            { 
                return runsBetterThanAvg; 
            }
            set 
            {
                runsBetterThanAvg = value; 
            }
        }
        public decimal WinsAboveAvg
        {
            get 
            { 
                return winsAboveAvg; 
            }
            set
            { 
                winsAboveAvg = value; 
            }
        }
        public int RunsFromReplacement
        {
            get 
            {
                return runsFromReplacement; 
            }
            set 
            { 
                runsFromReplacement = value; 
            }
        }
        public int RunsAboveReplacement
        {
            get 
            { 
                return runsAboveReplacement; 
            }
            set 
            { 
                runsAboveReplacement = value; 
            }
        }
        public decimal WinsAboveReplacement
        {
            get 
            { 
                return winsAboveReplacement; 
            }
            set 
            { 
                winsAboveReplacement = value; 
            }
        }
        public decimal WinLossWithAvgTeamPer
        {
            get 
            { 
                return winLossWithAvgTeamPer; 
            }
            set 
            { 
                winLossWithAvgTeamPer = value; 
            }
        }
        public decimal WinLossWithAvgTeamSeason
        {
            get 
            { 
                return winLossWithAvgTeamSeason;
            }
            set 
            { 
                winLossWithAvgTeamSeason = value;
            }
        }
        public decimal OffensiveWAR
        {
            get 
            { 
                return offensiveWAR;
            }
            set 
            { 
                offensiveWAR = value; 
            }
        }
        public decimal DeffensiveWAR
        {
            get 
            {
                return deffensiveWAR;
            }
            set 
            {
                deffensiveWAR = value; 
            }
        }
        public int OffensiveRunsAboveReplacment
        {
            get
            { 
                return offensiveRunsAboveReplacment;
            }
            set 
            {
                offensiveRunsAboveReplacment = value; 
            }
        }
        public int Salary
        {
            get 
            { 
                return salary; 
            }
            set
            { 
                salary = value; 
            }
        }
        public string Acquired
        {
            get 
            { 
                return acquired; 
            }
            set 
            { 
                acquired = value; 
            }
        }
        public string PosSummary
        {
            get 
            { 
                return posSummary; 
            }
            set
            { 
                posSummary = value; 
            }
        }
   }

}
