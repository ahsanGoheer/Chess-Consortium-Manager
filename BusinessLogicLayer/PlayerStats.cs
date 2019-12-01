using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{

    public class PlayerStats
    {
        //Attributes.       
        string cnic;
        int totalGamesPlayed;
        int totalGamesWon;
        int totalGamesLost;
        int totalGamesDrawn;
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 




        //Constructor. 
        public PlayerStats(string cnic)
        {
            this.cnic = cnic;
            this.totalGamesPlayed = 0; this.totalGamesWon = 0; this.totalGamesLost = 0; this.totalGamesDrawn = 0;
        }
        //---------------------------------------------------------------------------------------------- 

        public PlayerStats(string cnic, int totalGamesPlayed, int totalGamesWon, int totalGamesLost, int totalGamesDrawn)
        {
            this.cnic = cnic;
            this.totalGamesPlayed = totalGamesPlayed; this.totalGamesWon = totalGamesWon; this.totalGamesLost = totalGamesLost; this.totalGamesDrawn = totalGamesDrawn;
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 




        //Properties. 
        public string CNIC { get { return cnic; } set { this.cnic = value; } }
        //---------------------------------------------------------------------------------------------- 

        public int TotalGamesPlayed { get { return totalGamesPlayed; } }
        //---------------------------------------------------------------------------------------------- 

        public int TotalGamesWon { get { return totalGamesWon; } }
        //---------------------------------------------------------------------------------------------- 

        public int TotalGamesLost { get { return totalGamesLost; } }
        //---------------------------------------------------------------------------------------------- 

        public int TotalGamesDrawn { get { return totalGamesDrawn; } }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 




        //Methods.  
        public void gameWon()
        {
            totalGamesWon += 1;
            totalGamesPlayed = totalGamesWon + totalGamesLost + totalGamesDrawn;
        }
        //---------------------------------------------------------------------------------------------- 

        public void gameLost()
        {
            totalGamesLost += 1;
            totalGamesPlayed = totalGamesWon + totalGamesLost + totalGamesDrawn;
        }
        //---------------------------------------------------------------------------------------------- 

        public void gameDrawn()
        {
            totalGamesDrawn += 1;
            totalGamesPlayed = totalGamesWon + totalGamesLost + totalGamesDrawn;
        }
        //---------------------------------------------------------------------------------------------- 

        public string printStats()
        {
            string statsData = $"Total Games Played         : {this.TotalGamesPlayed} \n";
            statsData += $"Total Games Won            : {this.TotalGamesWon} \n";
            statsData += $"Total Games Lost           : {this.TotalGamesLost} \n";
            statsData += $"Total Games Drawn          : {this.TotalGamesDrawn} \n";
            return statsData;

        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

    }//End Class. 
}//End Namespace.
