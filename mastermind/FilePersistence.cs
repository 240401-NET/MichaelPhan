using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace mastermind;

class FilePersistence {

/* What will be the purpose for this class?
    1. If a leaderboard.json(or .txt) file is not available, create one
    2. Write player data (name, previous solves [the correct solution, total number of turns], total number of solves, fastest solve)
    3. Append the .json file with updates to any of the player data information above, or if any new players are added
    4. Load the file each time the console application is running
*/
// public static List<Player> LoadPreviousPlayers(List<Player> players) {

// }
    public static Player LoadPlayer(){

            try{
            string filePath = "playersScores.json";
            string jsonCharacters = File.ReadAllText(filePath);

            // characters is assigned the deserialized list of characters from the jsonCharacters string. ~ Ricardo PenaMcKnight
            Player playerX = JsonSerializer.Deserialize<Player>(jsonCharacters)!;
            return playerX!;
            }
        catch(Exception e)
        {
            Console.WriteLine(e.Message +"File not generated, first time execution!");
        }
        Player x = new("x", "x", GameMaster.previousSolutions);
        return x;
   
    }

public static void PersistCharacter(Player player) 
{
    string jsonPlayers = JsonSerializer.Serialize(player);

    string filePath = "playersScores.json";

    File.WriteAllText(filePath, jsonPlayers);
}


}