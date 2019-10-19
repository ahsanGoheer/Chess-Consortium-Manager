using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    namespace Chess_Consortium
    {
        class Player
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
            public void getPlayerInfo() 
            { 
                string playerData = "";
                playerData += $"Player Name : {this.PlayerName} \n";
                playerData += $"CNIC        : {this.CNIC} "; 
                Console.WriteLine(playerData); 
            } 
        //-------------------------------------------------------------------------------

 
    }//End Class. 
}//End Namespace. 

}
