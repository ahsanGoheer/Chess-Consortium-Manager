using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Manager
    {
        //Attributes. 
        ArrayList onGoingGames = new ArrayList(9);
        ArrayList registeredPlayers = new ArrayList();
        ArrayList playerStatistics = new ArrayList();

        //---------------------------------------------------------------------------------------------- 

        //Constructor. 
        public Manager()
        {
            FileHandler dataHandler = new FileHandler();
            registeredPlayers = dataHandler.RegisteredPlayers;
            playerStatistics = dataHandler.PlayerStatistics;
        }    
      
    //---------------------------------------------------------------------------------------------- 

    //Methods for managing players. 
    public bool registerNewPlayer(Player newPlayer)
        {


            bool alreadyRegistered = true;
            if (!playerRegistered(newPlayer.CNIC))
            {
                registeredPlayers.Add(newPlayer);
               
                PlayerStats newPlayerStats = new PlayerStats(newPlayer.CNIC);
                playerStatistics.Add(newPlayerStats);
                alreadyRegistered = false;

            }
            else
            {
                alreadyRegistered = true;
            }
            return alreadyRegistered;

        }

        public bool playerRegistered(string playerCnic)
        {
            bool isRegistered = false;
          
            Player temp = null;
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                temp = registeredPlayers[index] as Player;
                if (playerCnic == temp.CNIC)
                {
                    
                    isRegistered = true;
                    break;
                }
            }
            return isRegistered;
        }

        public PlayerStats fetchStats(string playerCnic)
        {
          
            PlayerStats locatedStats = null;
            bool statsExist = false;
            int locatedIndex = 0;
            for (int index = 0; index < playerStatistics.Count; index++)
            {
                if (playerCnic == (playerStatistics[index] as PlayerStats).CNIC)
                {
                    locatedIndex = index;
                    statsExist = true;
                    break;
                }
            }
            if (statsExist)
            {
                locatedStats = playerStatistics[locatedIndex] as PlayerStats;

            }
            else
            {
              
            }

            return locatedStats;
        }

        public void searchPlayer(string playerCnic)
        {
            bool isFound = false;
            
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
                
            }
            else
            {
               
            }
        }

        public void viewAllRegisteredPlayer()
        {
           
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                Player temp = registeredPlayers[index] as Player;
               
            }
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
                    gameFileHandler.writeGame(temp);
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
        public void showTableInfo()
        {
           
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                Game onGoingGame = onGoingGames[index] as Game;
                
            }
        }

        //---------------------------------------------------------------------------------------------- 
        //FileUpdater.
        public void UpdatePlayers()
        {
            FileHandler updateHandler = new FileHandler();
            updateHandler.updatePlayersFile(registeredPlayers);
        }
        public void UpdateStats()
        {
            FileHandler updateHandler = new FileHandler();
            updateHandler.updateStatsFile(playerStatistics);
        }
        //Destructor. 
        ~Manager()
        {
            //FileHandler updateHandler = new FileHandler();
            //updateHandler.updatePlayersFile(registeredPlayers);
            //updateHandler.updateStatsFile(playerStatistics);

        }
        //--------------------------------------------------------------------------------------------- 
    }
}

