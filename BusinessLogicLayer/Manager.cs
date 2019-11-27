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
    public class Manager
    {
        //Attributes. 
        private static readonly object padlock = new object();
        private static Manager instance = null;

        ArrayList onGoingGames = new ArrayList(9);
        ArrayList registeredPlayers = new ArrayList();
        ArrayList playerStatistics = new ArrayList();

        //---------------------------------------------------------------------------------------------- 

        //Constructor. 
        private Manager()
        {
            registeredPlayers = playerList();
            playerStatistics = statsList();
        }    
      
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

    //Methods for managing players. 
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
                //playerStatistics.Add(newPlayerStats);
                alreadyRegistered = false;

            }
         
            return alreadyRegistered;

        }

        public bool playerRegistered(string playerCnic)
        {
            bool isRegistered = false;
            DatabaseHandler registrationHandler = new DatabaseHandler();
            string query = "Select COUNT(PlayerCnic) from Player where PlayerCnic= '" + playerCnic+"'";
            object result=registrationHandler.SpecificQuery(query);
            int count = (int)result;
            if(count==1)
            {
                isRegistered = true;
            }
            registrationHandler.CloseConnection();
            return isRegistered;
        }

        public PlayerStats fetchStats(string playerCnic)
        {
          
            PlayerStats locatedStats = null;
            bool statsExist = false;
       
            DatabaseHandler playerStatsHandler = new DatabaseHandler();
            string query = $"Select * from PlayerStats where PlayerID = '{playerCnic}'";
            DataSet statsData = playerStatsHandler.ExceuteQuerySet(query);
            if(statsData.Tables[0].Rows.Count!=0)
            {
                statsExist = true;
            }
            //for (int index = 0; index < playerStatistics.Count; index++)
            //{
            //    if (playerCnic == (playerStatistics[index] as PlayerStats).CNIC)
            //    {
            //        locatedIndex = index;
            //        statsExist = true;
            //        break;
            //    }
            //}
            if (statsExist)
            {
                string cnic = statsData.Tables[0].Rows[0][0].ToString();
                string TotalGamesPlayed = statsData.Tables[0].Rows[0][1].ToString();
                string GamesWon = statsData.Tables[0].Rows[0][2].ToString();
                string GamesLost = statsData.Tables[0].Rows[0][3].ToString();
                string GamesDrawn = statsData.Tables[0].Rows[0][4].ToString();
                PlayerStats fetchedStats = new PlayerStats(cnic,int.Parse(TotalGamesPlayed),int.Parse(GamesWon),int.Parse(GamesLost),int.Parse(GamesDrawn));
                locatedStats =fetchedStats;

            }
          

            return locatedStats;
        }

        public string searchPlayer(string playerCnic)
        {
            bool isFound = false;
            string Info = null;
            Player locatedPlayer = null;
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                locatedPlayer = registeredPlayers[index] as Player;
                if (locatedPlayer.CNIC == playerCnic)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                PlayerStats locatedStats = fetchStats(locatedPlayer.CNIC);
                Info = locatedPlayer.getPlayerInfo();
                Info += locatedStats.printStats();
            }
           
            return Info;
        }

        public string viewAllRegisteredPlayer()
        {
            string playerInformation = null;
           
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                Player temp = registeredPlayers[index] as Player;
                playerInformation += temp.getPlayerInfo();
                PlayerStats getStats = fetchStats(temp.CNIC);
                if(getStats==null)
                {
                    playerInformation += "Nothing";
                }
                else
                {
                    playerInformation += getStats.printStats();
                    playerInformation += "****************************************\n";
                }
                
            }
            return playerInformation;
        }
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

        //Manager Controls for The Program. 
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
                    FileHandler gameFileHandler = new FileHandler();
                    
                    gameFileHandler.writeGame(gameToStrArray(temp));
                    onGoingGames.Remove(temp);
                    break;
                }

            }
        }

        public void updateStats(string cnic, byte outcome)
        {
            for (int index = 0; index < playerStatistics.Count; index++)
            {
                PlayerStats reqStats = playerStatistics[index] as PlayerStats;
                if (reqStats.CNIC == cnic)
                {
                    if (outcome == 1)
                    {
                        reqStats.gameWon();
                    }
                    else if (outcome == 2)
                    {
                        reqStats.gameLost();
                    }
                    else if (outcome == 3)
                    {
                        reqStats.gameDrawn();
                    }
                    break;
                }

            }
        }
        //---------------------------------------------------------------------------------------------- 


        //Methods for Managing Tables. 
        public bool assignGame(Game assignedgame )
        {

            Game newGame = assignedgame;
            bool gameAssigned = false;
            if (!isAlreadyPlaying(newGame.PlayerOneCnic) && !isAlreadyPlaying(newGame.PlayerTwoCnic))
            {
                if (isRegistered(newGame.PlayerOneCnic) && newGame.PlayerTwoCnic == null)
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
                else if ((isRegistered(newGame.PlayerOneCnic) && isRegistered(newGame.PlayerTwoCnic)) && newGame.PlayerTwoCnic != null)
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
        public bool isRegistered(string playerCnic)
        {
            bool exists = false;
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                Player temp = registeredPlayers[index] as Player;
                if (playerCnic == temp.CNIC)
                {
                    exists = true;
                    break;
                }

            }
            return exists;
        }
        public bool isAvailable()
        {
            bool hasTable = false;
            if (onGoingGames.Count < 9)
            {
                hasTable = true;
            }
            return hasTable;
        }
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

        //Convert to Player list.
        public ArrayList playerList()
        {
            ArrayList storedPlayers = new ArrayList();
            FileHandler DataHandler = new FileHandler();
            foreach(string[] temp in DataHandler.RegisteredPlayers)
            {
                Player newPlayer = new Player(temp[1],temp[0]);
                storedPlayers.Add(newPlayer);
            }
            return storedPlayers;
        }
        //Convert To Stats list.
        public ArrayList statsList()
        {
            ArrayList playerStats = new ArrayList();
            FileHandler DataHandler = new FileHandler();
            foreach(string[] temp in DataHandler.PlayerStatistics)
            {
                PlayerStats newStats = new PlayerStats(temp[0],int.Parse(temp[1]),int.Parse(temp[2]),int.Parse(temp[3]),int.Parse(temp[4]));
                playerStats.Add(newStats);
            }
            return playerStats;

        }
        //Convert Game to String Array
        public string[] gameToStrArray(Game game)
        {
            string[] gameData = new string[5];
            gameData[0]=game.TableID;
            gameData[1] = game.PlayerOneCnic;
            gameData[2] = game.PlayerTwoCnic;
            gameData[3] = game.DateTimeOfGame.ToString();
            gameData[4] = game.Outcome.ToString();
            return gameData;
        }
        //Convert Player List to String Array List
        public ArrayList playerToStrArrayList(ArrayList players)
        {
            ArrayList playerStrArrays = new ArrayList();
            foreach(Player temp in players)
            {
                string[] player = new string[2];
                player[0] = temp.CNIC;
                player[1] = temp.PlayerName;
                playerStrArrays.Add(player);
            }
            return playerStrArrays;
        }
        //Convert Player Stats to String Array List
        public ArrayList playerStatsToStrArrayList(ArrayList playStats)
        {
            ArrayList playerStatsList = new ArrayList();
            foreach(PlayerStats temp in playStats)
            {
                string[] stats = new string[5];
                stats[0]=temp.CNIC;
                stats[1] = temp.TotalGamesPlayed.ToString();
                stats[2] = temp.TotalGamesWon.ToString();
                stats[3] = temp.TotalGamesLost.ToString();
                stats[4] = temp.TotalGamesDrawn.ToString();
                playerStatsList.Add(stats);
            }
            return playerStatsList;
        }
        //FileUpdater.
        public void UpdatePlayers()
        {
            FileHandler updateHandler = new FileHandler();
            updateHandler.updatePlayersFile(playerToStrArrayList(registeredPlayers));
        }
        public void UpdateStats()
        {
            FileHandler updateHandler = new FileHandler();
            updateHandler.updateStatsFile(playerStatsToStrArrayList(playerStatistics));
        }
        //Check if table is occupied.
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
        //--------------------------------------------------------------------------------------------- 
    }
}

