using System.Drawing;
using Microsoft.VisualBasic;

namespace mastermind;

class GameMaintenance {

/* What is this class in charge of?
    1. Creating the secret four color code each time a new game instance is ran
    2. Take player's guess and compare that to the secret code
    3. What to do with the guess:
        3. Check if the guess correctly matches the secret code
            3.a If yes, print winner message, end instance of the game and update player data 
            (previous solves [correct code, number of turns])
            3.b. If no, update turn counter, give player feedback based on their guess 
            and proceed with the game until maximum number of turns reached, or the correct code
            is guessed.
    4. Prompt user to continue a new game or to end the application entirely.
*/
    // possible colors that the color code combination can be made from
    public static string[] colors = ["R", "Y", "B", "G", "O", "P"];

    public static string[] GenerateColorCode(string[] colors) {
        string[] secreteCode = new string[4];
        for (int i = 0; i < secreteCode.Length; i++)
        {
            secreteCode[i] = colors[RandomNumber()];
        }
        return secreteCode;
    }

    // Tested that Secrete code creates a code with duplicates and contains all colors in the colors array: Passed
    // public static void printSecretCode (string [] secretCode) {
    //     foreach (string color in secretCode) {
    //         Console.WriteLine($"The Color code is: {color}");
    //     }
    // }

    private static int RandomNumber() {
        int zeroIndexing = 0;
        Random rng = new();
        zeroIndexing += rng.Next(0, 6);
        return zeroIndexing;
    }
}