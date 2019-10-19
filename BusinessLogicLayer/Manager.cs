using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class Manager
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
        }
        playerStatistics = dataHandler.PlayerStatistics; 
            
      
    //---------------------------------------------------------------------------------------------- 

    //Methods for managing players. 
    public void registerNewPlayer()
        {

            InputOutputHandler playerInfoHandler = new InputOutputHandler();
            Player newPlayer = playerInfoHandler.inputPlayerInfo();
            if (!playerRegistered(newPlayer.CNIC))
            {
                registeredPlayers.Add(newPlayer);
                playerInfoHandler.printPlayerInfo(newPlayer);
                PlayerStats newPlayerStats = new PlayerStats(newPlayer.CNIC);
                playerStatistics.Add(newPlayerStats);
                playerInfoHandler.playerAddedConfirmation();

            }
            else
            {
                playerInfoHandler.playerAlreadyRegistered();
            }

        }

        public bool playerRegistered(string playerCnic)
        {
            bool isRegistered = false;
            InputOutputHandler playerInfoHandler = new InputOutputHandler();
            Player temp = null;
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                temp = registeredPlayers[index] as Player;
                if (playerCnic == temp.CNIC)
                {
                    playerInfoHandler.printPlayerInfo(temp);
                    isRegistered = true;
                    break;
                }
            }
            return isRegistered;
        }

        public PlayerStats fetchStats(string playerCnic)
        {
            InputOutputHandler errorHandler = new InputOutputHandler();
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
                errorHandler.statsNotFound();
            }

            return locatedStats;
        }

        public void searchPlayer(string playerCnic)
        {
            bool isFound = false;
            InputOutputHandler playerInfoHandler = new InputOutputHandler();
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
                playerInfoHandler.getPlayerDetails(locatedPlayer, locatedStats);
            }
            else
            {
                playerInfoHandler.playerNotFound();
            }
        }

        public void viewAllRegisteredPlayer()
        {
            InputOutputHandler outputHandler = new InputOutputHandler();
            for (int index = 0; index < registeredPlayers.Count; index++)
            {
                Player temp = registeredPlayers[index] as Player;
                outputHandler.printPlayerInfo(temp);
            }
        }
        //---------------------------------------------------------------------------------------------- 

        //Manager Controls for The Program. 
        public void assignOutcome(string TableId)
        {
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                if (TableId == (onGoingGames[index] as Game).TableID)
                {
                    InputOutputHandler inputHandler = new InputOutputHandler();
                    byte choice = inputHandler.selectOutCome();
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
        public void assignGame()
        {
            InputOutputHandler gameDataHandler = new InputOutputHandler();
            Game newGame = gameDataHandler.inputGameData();
            if (!isAlreadyPlaying(newGame.PlayerOneCnic) && !isAlreadyPlaying(newGame.PlayerTwoCnic))
            {
                if (isRegistered(newGame.PlayerOneCnic) && newGame.PlayerTwoCnic == null)
                {
                    if (isPending())
                    {
                        Game temp = null;
                        for (int index = 0; index < onGoingGames.Count; index++)
                        {
                            if ((onGoingGames[index] as Game).PlayerTwoCnic == null)
                            {
                                temp = onGoingGames[index] as Game;
                                temp.PlayerTwoCnic = newGame.PlayerOneCnic;
                                temp.DateTimeOfGame = DateTime.Now;
                                Console.WriteLine($"Table : {temp.TableID} has been assigned!");

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
                            Console.WriteLine($"Table : {newGame.TableID} has been assigned!");
                        }
                        else
                        {
                            gameDataHandler.noTableAvailable();
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
                                temp.DateTimeOfGame = DateTime.Now; Console.WriteLine($"Table : {temp.TableID} has been assigned!");

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
                            Console.WriteLine($"Table : {newGame.TableID} has been assigned!");

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Operation can not be performed!");
            }

        }

        public bool isAlreadyPlaying(string playerCnic)
        {
            bool check = false; InputOutputHandler errorHandler = new InputOutputHandler();
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                Game temp = onGoingGames[index] as Game;
                if (playerCnic == temp.PlayerOneCnic && temp.PlayerOneCnic != null)
                {
                    check = true;
                    errorHandler.alreadyPlaying(temp.PlayerOneCnic);
                    break;
                }
                else if (playerCnic == temp.PlayerTwoCnic && temp.PlayerTwoCnic != null)
                {
                    check = true;
                    errorHandler.alreadyPlaying(temp.PlayerTwoCnic);
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
            InputOutputHandler tableDataHandler = new InputOutputHandler();
            for (int index = 0; index < onGoingGames.Count; index++)
            {
                Game onGoingGame = onGoingGames[index] as Game;
                tableDataHandler.getTableInfo(onGoingGame);
            }
        }

        //---------------------------------------------------------------------------------------------- 

        //Destructor. 
        ~Manager()
        {
            FileHandler updateHandler = new FileHandler();
            updateHandler.updatePlayersFile(registeredPlayers);
            updateHandler.updateStatsFile(playerStatistics);

        }
        //--------------------------------------------------------------------------------------------- 
    }
}

