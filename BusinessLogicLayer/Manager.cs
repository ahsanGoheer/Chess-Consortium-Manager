using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLogicLayer
{
    public class Manager //Facade controller as Singleton.
    {
        //Attributes. 
        private static readonly object padlock = new object();
        private static Manager instance = null;
        ArrayList onGoingGames = new ArrayList(9);
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


        //Constructor. 
        private Manager()
        {    }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


        //Returns the only instance of the facade controller.
        public static Manager Instance
        {
            get
            {
                lock(padlock)
                {
                    if(instance==null)
                    {
                        instance = new Manager();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


        //Methods for Managing Players. 
        public bool registerNewPlayer(Player newPlayer)
        {


            bool alreadyRegistered = true;
            DatabaseHandler registrationHandler = new DatabaseHandler();
            if (!playerRegistered(newPlayer.CNIC))
            {
                string playerInsertQuery = $"Insert into Player(PlayerName,PlayerCnic) values('{newPlayer.PlayerName}','{newPlayer.CNIC}')";
                int status=registrationHandler.InsertQuery(playerInsertQuery);
                //registeredPlayers.Add(newPlayer);
                if(status==1)
                {
                    PlayerStats newPlayerStats = new PlayerStats(newPlayer.CNIC);
                    string playerStatsInsertQuery = $"Insert into PlayerStats(PlayerID,GamesPlayed,GamesWon,GamesLost,GamesDrawn) values('{newPlayerStats.CNIC}','{newPlayerStats.TotalGamesPlayed}','{newPlayerStats.TotalGamesWon}','{newPlayerStats.TotalGamesLost}','{newPlayerStats.TotalGamesDrawn}')";
                    registrationHandler.InsertQuery(playerStatsInsertQuery);
                    registrationHandler.CloseConnection();
                }
                
                alreadyRegistered = false;

            }
         
            return alreadyRegistered;

        }
        //---------------------------------------------------------------------------------------------- 
        public ArrayList RankPlayers()
        {
            ArrayList statsList = fetchStats();
            ArrayList Ranks = new ArrayList(10);
            statsList.Sort(new StatsComparer());
            int counter = 0;
            if(statsList.Count>10)
            {
                counter = 10;
            }
            else
            {
                counter = statsList.Count-1;
            }
            for(int i=counter;i>0;i--)
            {
                string[] rankList = new string[3];
                rankList[0] =(statsList[i] as PlayerStats).CNIC;
                rankList[1] = $"RANK: {(counter+1)-i}";
                rankList[2]= (statsList[i] as PlayerStats).TotalGamesWon.ToString();
                Ranks.Add(rankList);
            }
            return Ranks;
        }

        public string fetchName(string Cnic)
        {
            DatabaseHandler playerSearchHandler = new DatabaseHandler();
            string query = $"Select PlayerName from Player where  PlayerCnic='{Cnic}'";
            DataSet playerData = playerSearchHandler.ExceuteQuerySet(query);
            playerSearchHandler.CloseConnection();
            return playerData.Tables[0].Rows[0][0].ToString();
        }
        //---------------------------------------------------------------------------------------------- 

        public bool playerRegistered(string playerCnic)
        {
            bool isRegistered = false;
            if(playerCnic!="")
            {
                DatabaseHandler registrationHandler = new DatabaseHandler();
                string query = "Select COUNT(PlayerCnic) from Player where PlayerCnic= '" + playerCnic + "'";
                object result = registrationHandler.SpecificQuery(query);
                int count = (int)result;
                if (count == 1)
                {
                    isRegistered = true;
                }
                registrationHandler.CloseConnection();
            }
            
            return isRegistered;
        }
        //---------------------------------------------------------------------------------------------- 

        public ArrayList fetchStats()
        {
          
            ArrayList locatedStats=new ArrayList();
            DatabaseHandler playerStatsHandler = new DatabaseHandler();
            string query = $"Select * from PlayerStats";
            DataSet statsData = playerStatsHandler.ExceuteQuerySet(query);
            playerStatsHandler.CloseConnection();
          foreach (DataRow temp in statsData.Tables[0].Rows)
            {
                string cnic = temp[0].ToString();
                string TotalGamesPlayed = temp[1].ToString();
                string GamesWon = temp[2].ToString();
                string GamesLost = temp[3].ToString();
                string GamesDrawn = temp[4].ToString();
                PlayerStats fetchedStats = new PlayerStats(cnic, int.Parse(TotalGamesPlayed), int.Parse(GamesWon), int.Parse(GamesLost), int.Parse(GamesDrawn));
                locatedStats.Add(fetchedStats);

            }

            return locatedStats;
        }
        //---------------------------------------------------------------------------------------------- 

        public string searchPlayer(string playerCnic)
        {
            
            string Info = null;
            Player locatedPlayer = null;
            DatabaseHandler playerSearchHandler = new DatabaseHandler();
            string query = $"Select p.PlayerCnic,p.PlayerName,ps.GamesPlayed,ps.GamesWon,ps.GamesLost,ps.GamesDrawn from dbo.Player p JOIN dbo.PlayerStats ps ON p.PlayerCnic = ps.PlayerID where  p.PlayerCnic='{playerCnic}'";
            DataSet playerData =  playerSearchHandler.ExceuteQuerySet(query);
            playerSearchHandler.CloseConnection();
            if(playerData.Tables[0].Rows.Count!=0)
            {
                locatedPlayer = new Player(playerData.Tables[0].Rows[0][1].ToString(), playerData.Tables[0].Rows[0][0].ToString());
                Info = locatedPlayer.getPlayerInfo();
                PlayerStats locatedPlayerStats = new PlayerStats(playerData.Tables[0].Rows[0][0].ToString(),(int)playerData.Tables[0].Rows[0][2],(int)playerData.Tables[0].Rows[0][3],(int)playerData.Tables[0].Rows[0][4],(int)playerData.Tables[0].Rows[0][5]);
                Info += locatedPlayerStats.printStats();
            }
            
            return Info;
        }
        //---------------------------------------------------------------------------------------------- 

        public string searchPlayerByName(string playerName)
        {

            string Info = null;
            Player locatedPlayer = null;
            DatabaseHandler playerSearchHandler = new DatabaseHandler();
            string query = $"Select p.PlayerCnic,p.PlayerName,ps.GamesPlayed,ps.GamesWon,ps.GamesLost,ps.GamesDrawn from dbo.Player p JOIN dbo.PlayerStats ps ON p.PlayerCnic = ps.PlayerID where  p.PlayerName='{playerName}'";
            DataSet playerData = playerSearchHandler.ExceuteQuerySet(query);
            playerSearchHandler.CloseConnection();
            if (playerData.Tables[0].Rows.Count != 0)
            {
                Info = "";
                foreach(DataRow temp in playerData.Tables[0].Rows)
                {
                    locatedPlayer = new Player(temp[1].ToString(), temp[0].ToString());
                    Info += "*************************\n";
                    Info += locatedPlayer.getPlayerInfo();
                    PlayerStats locatedPlayerStats = new PlayerStats(temp[0].ToString(), (int)temp[2], (int)temp[3], (int)temp[4], (int)temp[5]);
                    Info += locatedPlayerStats.printStats();
                }
                
            }

            return Info;
        }
        //---------------------------------------------------------------------------------------------- 

        public string viewAllRegisteredPlayer()
        {
            string playerInformation = null;
            DatabaseHandler registeredPlayerHandler = new DatabaseHandler();
            string query = "Select p.PlayerCnic,p.PlayerName,ps.GamesPlayed,ps.GamesWon,ps.GamesLost,ps.GamesDrawn from dbo.Player p JOIN dbo.PlayerStats ps ON p.PlayerCnic = ps.PlayerID";
            DataSet registeredPlayerData = registeredPlayerHandler.ExceuteQuerySet(query);
            registeredPlayerHandler.CloseConnection();
            if(registeredPlayerData.Tables[0].Rows.Count!=0)
            {
                foreach(DataRow temp in registeredPlayerData.Tables[0].Rows)
                {
                    Player fetchedPlayer = new Player(temp[1].ToString(), temp[0].ToString());//PLAYER NAME AND CNIC
                    playerInformation += fetchedPlayer.getPlayerInfo();
                    PlayerStats fetchedPlayerStats = new PlayerStats(temp[0].ToString(),(int)temp[2],(int)temp[3],(int)temp[4],(int)temp[5]);//CNIC, GAMES PLAYED,GAMES WON,GAMES LOST,GAMES DRAWN
                    playerInformation += fetchedPlayerStats.printStats();
                    playerInformation += "****************************************\n";


                }
            }

           
            return playerInformation;
        }
        //---------------------------------------------------------------------------------------------- 
        public ArrayList fetchRegisteredPlayers()
        {
            ArrayList PlayersList = new ArrayList();
            DatabaseHandler registeredPlayerHandler = new DatabaseHandler();
            string query = "Select p.PlayerCnic,p.PlayerName from dbo.Player p";
            DataSet registeredPlayerData = registeredPlayerHandler.ExceuteQuerySet(query);
            registeredPlayerHandler.CloseConnection();
            if (registeredPlayerData.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow temp in registeredPlayerData.Tables[0].Rows)
                {
                    Player fetchedPlayer = new Player(temp[1].ToString(), temp[0].ToString());//PLAYER NAME AND CNIC
                    PlayersList.Add(fetchedPlayer);
                    

                }
            }


            return PlayersList;
        }
        //---------------------------------------------------------------------------------------------- 

        public List<string> tableIDs()
        {
            List<string> IDs = new List<string>();
            foreach(Game temp in onGoingGames)
            {
                IDs.Add(temp.TableID);
            }
            return IDs;
        }
        //---------------------------------------------------------------------------------------------- 
        public string getAllGames()
        {
            
            DatabaseHandler gamesRecordHandler = new DatabaseHandler();
            string query = "Select * from Game";
            DataSet gameData = gamesRecordHandler.ExceuteQuerySet(query);
            gamesRecordHandler.CloseConnection();
            string info = null;
            if (gameData.Tables[0].Rows.Count != 0)
            {
                info = "";
                foreach (DataRow temp in gameData.Tables[0].Rows)
                {
                    Game fetchedPlayer = new Game();//PLAYER NAME AND CNIC
                    fetchedPlayer.TableID = temp[0].ToString();
                    fetchedPlayer.DateTimeOfGame = (DateTime)temp[1];
                    fetchedPlayer.Outcome = byte.Parse(temp[2].ToString());
                    fetchedPlayer.PlayerOneCnic = temp[3].ToString();
                    fetchedPlayer.PlayerTwoCnic = temp[4].ToString();
                    info += fetchedPlayer.GetTableInfo();
                    info += "**************************************\n";

                }
            }

            return info;
           
        }
        public string getGame(DateTime gameDate)
        {

            DatabaseHandler gamesRecordHandler = new DatabaseHandler();
            string query = $"Select * from Game where DateTimeOfGame >'{gameDate}' and DateTimeOfGame<'{gameDate.AddDays(1)}'";
            DataSet gameData = gamesRecordHandler.ExceuteQuerySet(query);
            gamesRecordHandler.CloseConnection();
            string info = null;
            if (gameData.Tables[0].Rows.Count != 0)
            {
                info = "";
                foreach (DataRow temp in gameData.Tables[0].Rows)
                {
                    Game fetchedPlayer = new Game();//PLAYER NAME AND CNIC
                    fetchedPlayer.TableID = temp[0].ToString();
                    fetchedPlayer.DateTimeOfGame = (DateTime)temp[1];
                    fetchedPlayer.Outcome = byte.Parse(temp[2].ToString());
                    fetchedPlayer.PlayerOneCnic = temp[3].ToString();
                    fetchedPlayer.PlayerTwoCnic = temp[4].ToString();
                    info += fetchedPlayer.GetTableInfo();
                    info += "**************************************\n";

                }
            }

            return info;

        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


        //Manager Control Methods.
        public void deleteAPlayer(string Cnic)
        {
            if(playerRegistered(Cnic))
            {
                DatabaseHandler playerDeletionHandler = new DatabaseHandler();
                string query = $"Delete from PlayerStats where PlayerID='{Cnic}'";
                playerDeletionHandler.UpdateQuery(query);
                string playerDeleteQuery = $"Delete from Player where PlayerCnic='{Cnic}'";
                playerDeletionHandler.UpdateQuery(playerDeleteQuery);
            }
            else
            {
                throw new NoDataToShowException("Player not registered!");
            }
        }
        //---------------------------------------------------------------------------------------------- 

        public void assignOutcome(string TableId,byte choice)
        {
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                if (TableId == (onGoingGames[index] as Game).TableID)
                {
                 
                   
                    Game temp = onGoingGames[index] as Game;
                    temp.Outcome = choice;
                    if (choice == 1)
                    {
                        updateStats(temp.PlayerOneCnic, 1);
                        updateStats(temp.PlayerTwoCnic, 2);
                    }
                    else if (choice == 2)
                    {
                        updateStats(temp.PlayerOneCnic, 2);
                        updateStats(temp.PlayerTwoCnic, 1);
                    }
                    else if (choice == 3)
                    {
                        updateStats(temp.PlayerOneCnic, 3);
                        updateStats(temp.PlayerTwoCnic, 3);
                    }

                    if(InsertGame(temp))
                    {
                        onGoingGames.Remove(temp);

                    }
                    break;
                }

            }
        }
        //---------------------------------------------------------------------------------------------- 

        public bool InsertGame(Game newGame)
        {
            DatabaseHandler gameRecordHandler = new DatabaseHandler();
            string query = $"Insert into Game(TableID,PlayerOneCnic,PlayerTwoCnic,DateTimeOfGame,Outcome) values('{newGame.TableID}','{newGame.PlayerOneCnic}','{newGame.PlayerTwoCnic}','{newGame.DateTimeOfGame}',{newGame.Outcome})";
            int status =gameRecordHandler.InsertQuery(query);
            gameRecordHandler.CloseConnection();
            if(status==1)
            {
                return true;
            }
            return false;
           
        }
        //---------------------------------------------------------------------------------------------- 

        public void updateStats(string cnic, byte outcome)
        {
            DatabaseHandler statsOutcomeHandler = new DatabaseHandler();
            string query = $"Select * from PlayerStats where PlayerId='{cnic}'";
            DataSet fetchedStats = statsOutcomeHandler.ExceuteQuerySet(query);
            bool outcomeAssigned = false;
            if (fetchedStats.Tables[0].Rows.Count != 0)
            {
                DataRow statsDataRow = fetchedStats.Tables[0].Rows[0];
                PlayerStats reqStats = new PlayerStats(statsDataRow[0].ToString(), (int)statsDataRow[1], (int)statsDataRow[2], (int)statsDataRow[3], (int)statsDataRow[4]);
                if (reqStats.CNIC.Trim() == cnic.Trim())
                {
                    if (outcome == 1)
                    {
                        reqStats.gameWon();
                        outcomeAssigned = true;
                    }
                    else if (outcome == 2)
                    {
                        reqStats.gameLost();
                        outcomeAssigned = true;

                    }
                    else if (outcome == 3)
                    {
                        reqStats.gameDrawn();
                        outcomeAssigned = true;

                    }

                }
                if (outcomeAssigned)
                {
                    string updateQuery = $"Update PlayerStats set GamesPlayed={reqStats.TotalGamesPlayed}, GamesWon={reqStats.TotalGamesWon},GamesLost={reqStats.TotalGamesLost},GamesDrawn={reqStats.TotalGamesDrawn} where PlayerID='{reqStats.CNIC}'";
                    statsOutcomeHandler.UpdateQuery(updateQuery);
                    statsOutcomeHandler.CloseConnection();
                }
            }    
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


        //Methods for Managing Tables. 
        public bool assignGame(Game assignedgame )
        {

            Game newGame = assignedgame;
            bool gameAssigned = false;
            if (!isAlreadyPlaying(newGame.PlayerOneCnic) && !isAlreadyPlaying(newGame.PlayerTwoCnic))
            {
                if (playerRegistered(newGame.PlayerOneCnic) && newGame.PlayerTwoCnic == null)
                {
                    if (isPending())
                    {
                        Game temp = null;
                        Game temp2 = null;
                        for (int index = 0; index < onGoingGames.Count; index++)
                        {
                            if ((onGoingGames[index] as Game).PlayerTwoCnic == null)
                            {
                                temp = onGoingGames[index] as Game;
                                temp.PlayerTwoCnic = newGame.PlayerOneCnic;
                                temp.DateTimeOfGame = DateTime.Now;
                                temp2 = newGame;
                                temp2.TableID = temp.TableID;
                                gameAssigned = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (isAvailable())
                        {
                            newGame.setTableID();
                            onGoingGames.Add(newGame);
                            gameAssigned = true;
                        }
                        else
                        {
                            gameAssigned = false ;
                        }
                    }
                }
                else if ((playerRegistered(newGame.PlayerOneCnic) && playerRegistered(newGame.PlayerTwoCnic)) && newGame.PlayerTwoCnic != null)
                {
                    if (isPending())
                    {
                        Game temp = null;
                        for (int index = 0; index < onGoingGames.Count; index++)
                        {
                            if ((onGoingGames[index] as Game).PlayerTwoCnic == null)
                            {
                                temp = onGoingGames[index] as Game;
                                temp.PlayerOneCnic = newGame.PlayerOneCnic;
                                temp.PlayerTwoCnic = newGame.PlayerTwoCnic;
                                temp.DateTimeOfGame = DateTime.Now;
                                gameAssigned = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (isAvailable())
                        {
                            newGame.setTableID();
                            onGoingGames.Add(newGame);
                            gameAssigned = true;

                        }
                    }
                }
            }
            else
            {
                gameAssigned = false;
            }
            return gameAssigned;

        }
        //---------------------------------------------------------------------------------------------- 

        public bool isAlreadyPlaying(string playerCnic)
        {
            bool check = false;
          
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                Game temp = onGoingGames[index] as Game;
                if (playerCnic == temp.PlayerOneCnic && temp.PlayerOneCnic != null)
                {
                    check = true;
                    
                    break;
                }
                else if (playerCnic == temp.PlayerTwoCnic && temp.PlayerTwoCnic != null)
                {
                    check = true;
                   
                    break;
                }
            }
            return check;

        }
        //---------------------------------------------------------------------------------------------- 


        public bool isPending()
        {
            bool isPendingOpponent = false;
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                if ((onGoingGames[index] as Game).PlayerTwoCnic == null)
                {
                    isPendingOpponent = true;
                    break;
                }
            }
            return isPendingOpponent;
        }
        //---------------------------------------------------------------------------------------------- 

        public bool isAvailable()
        {
            bool hasTable = false;
            if (onGoingGames.Count < 9)
            {
                hasTable = true;
            }
            return hasTable;
        }
        //---------------------------------------------------------------------------------------------- 

        public string showTableInfo()
        {
            string tablesInfo ="";
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                Game onGoingGame = onGoingGames[index] as Game;
                tablesInfo += onGoingGame.GetTableInfo();
                tablesInfo += "*************************************\n";
            }
            return tablesInfo;
        }
        //---------------------------------------------------------------------------------------------- 
        public string getTableData(string TableId)
        {
            string tableData = null;
            for(int index=0;index<onGoingGames.Count;index++)
            {
                Game onGoingGame = onGoingGames[index] as Game;
                if(onGoingGame.TableID==TableId)
                {
                    tableData = onGoingGame.GetTableInfo();
                    break;
                }
            }
            return tableData;
        }

        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

        ////Check if table is occupied.
        public bool isOccupied(string TableID)
        {
            bool check = false;
            Game requiredGame = null;
            foreach(Game temp in onGoingGames)
            {
                if(TableID==temp.TableID)
                {
                    requiredGame = temp;
                }
            }
            if(requiredGame.PlayerOneCnic!=null&&requiredGame.PlayerTwoCnic!=null)
            {
                check = true;
            }
            return check;
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 
        //--------------------------------------------------------------------------------------------- 
    }//End Class.
}//End Namespace.

