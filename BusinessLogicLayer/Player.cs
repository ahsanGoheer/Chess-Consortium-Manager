using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   
        public class Player
        {
            //Attributes.   
            string playerName;
            string cnic; 
         
        //------------------------------------------------------------------------------- 
         
 
        //Constructor. 
        public Player(string playerName, string cnic)
            {
                this.playerName = playerName;
                this.cnic = cnic;
            }
            //-------------------------------------------------------------------------------



            //Properties.     
            public string PlayerName { get { return playerName; } set { playerName = value; } }

            
            public string CNIC { get { return cnic; } set { cnic = value; } }
            //-------------------------------------------------------------------------------

            //Methods.      
            public string getPlayerInfo() 
            { 
                string playerData = "";
                playerData += $"Player Name : {this.PlayerName} \n";
                playerData += $"CNIC        : {this.CNIC} \n";
                return playerData;
            } 
        //-------------------------------------------------------------------------------

 
    }//End Class. 
}//End Namespace. 


