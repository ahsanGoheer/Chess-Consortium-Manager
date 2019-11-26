using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class FileHandler
    {
        //Attributes.     
        ArrayList registeredPlayers = new ArrayList();
        ArrayList playerStatistics = new ArrayList();

        //--------------------------------------------------------------------------------------------- 

        //Constructor.      
        public FileHandler()
        {
            if (!File.Exists("Players.txt"))
            {
                StreamWriter fileCreator = new StreamWriter("Players.txt", true);
                fileCreator.Flush();
                fileCreator.Dispose();
            }
            if (!File.Exists("Games.txt"))
            {
                StreamWriter fileCreator = new StreamWriter("Games.txt", true);
                fileCreator.Flush();
                fileCreator.Dispose();
            }
            if (!File.Exists("Records.txt"))
            {
                StreamWriter fileCreator = new StreamWriter("Records.txt", true);
                fileCreator.Flush();
                fileCreator.Dispose();
            }
            registeredPlayers = ReadPlayerFile();
            playerStatistics = ReadGameRecords();

        }
        //--------------------------------------------------------------------------------------------- 

        //Properties. 
        public ArrayList RegisteredPlayers { get { return registeredPlayers; } set { this.registeredPlayers = value; } }
        public ArrayList PlayerStatistics { get { return playerStatistics; } set { playerStatistics = value; } }

        //--------------------------------------------------------------------------------------------- 

        //File Reader Method.   
        public ArrayList ReadPlayerFile()
        {
            StreamReader playerFileReader = new StreamReader("Players.txt", true);
            ArrayList playersInFile = new ArrayList();
            while (!playerFileReader.EndOfStream)
            {
                string playerName = playerFileReader.ReadLine();
                string cnic = playerFileReader.ReadLine();
                string[] playerData = new string[2];
                playerData[0] = playerName;
                playerData[1] = cnic;
                playersInFile.Add(playerData);
            }
            playerFileReader.Dispose();
            return playersInFile;
        }

        public ArrayList ReadGameRecords()
        {
            StreamReader playerStatsReader = new StreamReader("Records.txt", true);
            ArrayList recordsInFile = new ArrayList();
            while (!playerStatsReader.EndOfStream)
            {
                string cnic = playerStatsReader.ReadLine();
                string totalGamesPlayed = playerStatsReader.ReadLine();
                string totalGamesWon = playerStatsReader.ReadLine();
                string totalGamesLost = playerStatsReader.ReadLine();
                string totalGamesDrawn = playerStatsReader.ReadLine();

                string[] gameRecord = new string[5];
                gameRecord[0] = cnic;
                gameRecord[1] = totalGamesPlayed;
                gameRecord[2] = totalGamesWon;
                gameRecord[3] = totalGamesLost;
                gameRecord[4] = totalGamesDrawn;
                recordsInFile.Add(gameRecord);

            }
            playerStatsReader.Dispose();
            return recordsInFile;

        }         //---------------------------------------------------------------------------------------------          

        //File Writer Methods.     
        public void writeGame(string[] gameData)
        {
            FileStream gamesFileStream = new FileStream("Games.txt", FileMode.Append, FileAccess.Write);
            StreamWriter gamesFileWriter = new StreamWriter(gamesFileStream);
            if (gameData[2] != null && byte.Parse(gameData[4]) != 0)
            {
                gamesFileWriter.WriteLine(gameData[0]);//TABLE ID
                gamesFileWriter.WriteLine(gameData[1]);//PLAYER ONE CNIC
                gamesFileWriter.WriteLine(gameData[2]);//PLAYER TWO CNIC
                gamesFileWriter.WriteLine(gameData[3]);//DATETIMEOFGAME
                gamesFileWriter.WriteLine(gameData[4]);//OUTCOME
            }
            gamesFileWriter.Flush();
            gamesFileWriter.Dispose();
            gamesFileStream.Dispose();
        }
        public void writePlayer(string PlayerName, string CNIC)
        {
            FileStream playerFileStream = new FileStream("Players.txt", FileMode.Append, FileAccess.Write);
            StreamWriter playerFileWriter = new StreamWriter(playerFileStream);
            playerFileWriter.WriteLine(PlayerName);
            playerFileWriter.WriteLine(CNIC);
            string[] playerData = new string[2];
            playerData[0] = PlayerName;
            playerData[1] = CNIC;
            playerFileWriter.Flush();
            playerFileWriter.Dispose();
            playerFileStream.Dispose();
            registeredPlayers.Add(playerData);

        }

        public void writeRecord(string CNIC, string TotalGamesPlayed, string TotalGamesWon, string TotalGamesLost, string TotalGamesDrawn)
        {
            FileStream recordFileStream = new FileStream("Records.txt", FileMode.Append, FileAccess.Write);
            StreamWriter recordFileWriter = new StreamWriter(recordFileStream);
            recordFileWriter.WriteLine(CNIC);
            recordFileWriter.WriteLine(TotalGamesPlayed);
            recordFileWriter.WriteLine(TotalGamesWon);
            recordFileWriter.WriteLine(TotalGamesLost);
            recordFileWriter.WriteLine(TotalGamesDrawn);
            string[] newRecord = new string[5];
            newRecord[0] = CNIC;
            newRecord[1] = TotalGamesPlayed;
            newRecord[2] = TotalGamesWon;
            newRecord[3] = TotalGamesLost;
            newRecord[4] = TotalGamesDrawn;
            recordFileWriter.Flush();
            recordFileWriter.Dispose();
            recordFileStream.Dispose();
            playerStatistics.Add(newRecord);

        }         //---------------------------------------------------------------------------------------------         

        //Update files.  
        public void writeGames(ArrayList allGames)
        {
            FileStream gamesFileStream = new FileStream("Games.txt", FileMode.Append, FileAccess.Write);
            StreamWriter gamesFileWriter = new StreamWriter(gamesFileStream);
            for (int index = 0; index < allGames.Count; index++)
            {
                String[] gameToStore = allGames[index] as String[];
                if (gameToStore[2] != null && byte.Parse(gameToStore[4]) != 0)
                {
                    gamesFileWriter.WriteLine(gameToStore[0].Trim());// TABLE ID
                    gamesFileWriter.WriteLine(gameToStore[1].Trim());// PLAYER ONE CNIC
                    gamesFileWriter.WriteLine(gameToStore[2].Trim());// PLAYER TWO CNIC
                    gamesFileWriter.WriteLine(gameToStore[3].Trim());// DATE TIME OF GAME
                    gamesFileWriter.WriteLine(gameToStore[4].Trim());// OUTCOME OF THE GAME
                }
            }
            gamesFileWriter.Flush();
            gamesFileWriter.Dispose();
            gamesFileStream.Dispose();
        }
        public void updatePlayersFile(ArrayList allRegisteredPlayers)
        {
            FileStream playersFileStream = new FileStream("Players.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter playersFileWriter = new StreamWriter(playersFileStream);
            for (int index = 0; index < allRegisteredPlayers.Count; index++)
            {
                string[] playerToStore = allRegisteredPlayers[index] as string[];
                playersFileWriter.WriteLine(playerToStore[0].Trim()); // PLAYER NAME
                playersFileWriter.WriteLine(playerToStore[1].Trim()); // PLAYER CNIC
            }
            playersFileWriter.Flush();
            playersFileWriter.Dispose();
            playersFileStream.Dispose();
        }

        public void updateStatsFile(ArrayList allGameRecords)
        {
            FileStream recordsFileStream = new FileStream("Records.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter recordsFileWriter = new StreamWriter(recordsFileStream);
            for (int index = 0; index < allGameRecords.Count; index++)
            {
                string[] recordToStore = allGameRecords[index] as string[];
                recordsFileWriter.WriteLine(recordToStore[0].Trim());//PLAYER CNIC
                recordsFileWriter.WriteLine(recordToStore[1].Trim());//TOTAL GAMES PLAYED
                recordsFileWriter.WriteLine(recordToStore[2].Trim());//TOTAL GAMES WON
                recordsFileWriter.WriteLine(recordToStore[3].Trim());//TOTAL GAMES LOST
                recordsFileWriter.WriteLine(recordToStore[4].Trim());//TOTAL GAMES DRAWN
            }
            recordsFileWriter.Flush();
            recordsFileWriter.Dispose();
            recordsFileStream.Dispose();
        }

        
        //---------------------------------------------------------------------------------------------             


    }
}
