using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    
        public class Game
        {
            //Attributes.       
            string tableID;
            string playerOneCnic;
            string playerTwoCnic;
            DateTime dateTimeOfGame;
            byte outcome;
            static byte count=0; 
            //--------------------------------------------------------------------------------- 

            //Constructor. 

            public Game(string playerOneCnic, string playerTwoCnic, DateTime dateTimeOfGame)
            {
                this.tableID = null;// will be assigned through set method.        
                this.playerOneCnic = playerOneCnic;
                this.playerTwoCnic = playerTwoCnic;
                this.dateTimeOfGame =dateTimeOfGame;
                this.outcome = 0;// Means game is in progress.              
            }
            //----------------------------------------------------------------------------------- 

            //Properties. 
            public string TableID
            {
                get { return this.tableID; }
                set { this.tableID = value; }
            }
            public string PlayerOneCnic
            {
                get { return this.playerOneCnic; }
                set
                { this.playerOneCnic = value; }
            }

            public string PlayerTwoCnic
            {
                get { return this.playerTwoCnic; }
                set
                { this.playerTwoCnic = value; }
            }

            public DateTime DateTimeOfGame
            {
                get { return this.dateTimeOfGame; }
                set
                { dateTimeOfGame = value; }
            }
            public byte Outcome { get { return this.outcome; } set { this.outcome = value; } }   
            //----------------------------------------------------------------------------------- 

            //Methods.         
            public void setTableID() 
            {
                count += 1;
                if (count > 9) 
                { 
                 count = 1; 
                }
                this.tableID = $"T-{count}"; 
            }

            public void PrintTableInfo()
            {
                string tableInfo = "";
                tableInfo += $"Table I : {this.tableID} \n"; tableInfo += $"Player One ID         : {this.playerOneCnic} \n"; tableInfo += $"Player Two ID         : {this.playerTwoCnic} \n"; tableInfo += $"Date and Time of Game : {this.dateTimeOfGame} \n"; tableInfo += $"Outcome               : {this.outcome} \n";
                Console.WriteLine(tableInfo);
            } 
            //-------------------------------------------------------------------------------

 

        } 

}
