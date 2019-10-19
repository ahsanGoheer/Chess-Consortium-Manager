using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BusinessLogicLayer
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
                Player registeredPlayer = new Player(playerName, cnic);
                playersInFile.Add(registeredPlayer);
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
                int totalGamesPlayed = int.Parse(playerStatsReader.ReadLine());
                int totalGamesWon = int.Parse(playerStatsReader.ReadLine());
                int totalGamesLost = int.Parse(playerStatsReader.ReadLine());
                int totalGamesDrawn = int.Parse(playerStatsReader.ReadLine());
                PlayerStats storedRecord = new PlayerStats(cnic, totalGamesPlayed, totalGamesWon, totalGamesLost, totalGamesDrawn);
                recordsInFile.Add(storedRecord);
            }
            playerStatsReader.Dispose(); return recordsInFile;

        }         //---------------------------------------------------------------------------------------------          

        //File Writer Methods.     
        public void writeGame(Game completedGame)
        {
            FileStream gamesFileStream = new FileStream("Games.txt", FileMode.Append, FileAccess.Write);
            StreamWriter gamesFileWriter = new StreamWriter(gamesFileStream);
            Game gameToStore = completedGame;
            if (gameToStore.PlayerTwoCnic != null && gameToStore.Outcome != 0)
            {
                gamesFileWriter.WriteLine(gameToStore.TableID);
                gamesFileWriter.WriteLine(gameToStore.PlayerOneCnic);
                gamesFileWriter.WriteLine(gameToStore.PlayerTwoCnic);
                gamesFileWriter.WriteLine(gameToStore.DateTimeOfGame);
                gamesFileWriter.WriteLine(gameToStore.Outcome);
            }
            gamesFileWriter.Flush();
            gamesFileWriter.Dispose();
            gamesFileStream.Dispose();
        }
        public void writePlayer(Player newPlayer)
        {
            FileStream playerFileStream = new FileStream("Players.txt", FileMode.Append, FileAccess.Write);
            StreamWriter playerFileWriter = new StreamWriter(playerFileStream);
            playerFileWriter.WriteLine(newPlayer.PlayerName);
            playerFileWriter.WriteLine(newPlayer.CNIC);
            playerFileWriter.Flush();
            playerFileWriter.Dispose();
            playerFileStream.Dispose();
            registeredPlayers.Add(newPlayer);
        }

        public void writeRecord(PlayerStats newRecord)
        {
            FileStream recordFileStream = new FileStream("Records.txt", FileMode.Append, FileAccess.Write);
            StreamWriter recordFileWriter = new StreamWriter(recordFileStream);
            recordFileWriter.WriteLine(newRecord.CNIC);
            recordFileWriter.WriteLine(newRecord.TotalGamesPlayed);
            recordFileWriter.WriteLine(newRecord.TotalGamesWon);
            recordFileWriter.WriteLine(newRecord.TotalGamesLost);
            recordFileWriter.WriteLine(newRecord.TotalGamesDrawn);
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
                Game gameToStore = allGames[index] as Game;
                if (gameToStore.PlayerTwoCnic != null && gameToStore.Outcome != 0)
                {
                    gamesFileWriter.WriteLine(gameToStore.TableID);
                    gamesFileWriter.WriteLine(gameToStore.PlayerOneCnic);
                    gamesFileWriter.WriteLine(gameToStore.PlayerTwoCnic);
                    gamesFileWriter.WriteLine(gameToStore.DateTimeOfGame);
                    gamesFileWriter.WriteLine(gameToStore.Outcome);
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
                Player playerToStore = allRegisteredPlayers[index] as Player;
                playersFileWriter.WriteLine(playerToStore.PlayerName);
                playersFileWriter.WriteLine(playerToStore.CNIC);
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
                PlayerStats recordToStore = allGameRecords[index] as PlayerStats;
                recordsFileWriter.WriteLine(recordToStore.CNIC);
                recordsFileWriter.WriteLine(recordToStore.TotalGamesPlayed);
                recordsFileWriter.WriteLine(recordToStore.TotalGamesWon);
                recordsFileWriter.WriteLine(recordToStore.TotalGamesLost);
                recordsFileWriter.WriteLine(recordToStore.TotalGamesDrawn);
            }
            recordsFileWriter.Flush();
            recordsFileWriter.Dispose();
            recordsFileStream.Dispose();
        }
        //---------------------------------------------------------------------------------------------             }//End Class. }//End Namespace. 

    }
}
