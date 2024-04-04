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

    public static string[] GenerateColorCode(string[] colors) 
    {
        string[] secreteCode = new string[4];
        for (int i = 0; i < secreteCode.Length; i++)
        {
            secreteCode[i] = colors[RandomNumber()];
        }
        return secreteCode;
    }

    private static int RandomNumber() 
    {
        int zeroIndexing = 0;
        Random rng = new();
        zeroIndexing += rng.Next(0, 6);
        return zeroIndexing;
    }

    // Tested that Secrete code creates a code with duplicates and contains all colors in the colors array: Passed
    // public static void printSecretCode (string [] secretCode) {
    //     foreach (string color in secretCode) {
    //         Console.WriteLine($"The Color code is: {color}");
    //     }
    // }

    public static bool ValidGuess (string[] guess, string[] color) 
    {
        if (guess.Length == 4 & CheckIfGuessOnlyHasValidColors(guess, color) == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public static string GetGuess() 
    {
        Console.WriteLine("Please enter your 4-color code using the letters R, G, B, Y, O, and P");
        string guess = Console.ReadLine()!.ToUpper();
        // This comment checks to see if the the program is taking the user's guess and changing the input into all caps: Check!
        // Console.WriteLine(guess);
        return guess;
    }

    public static string[] ConvertGuessToArray (string guess) {
        string[] guessArray = guess.Split(" ");
        // Test if guess is correctly converted into an array of string (chars): Passed
        // for (int i = 0; i < guessArray.Length; i++){
        //     // Console.Write(guessArray[i]);
        // }
        return guessArray;
    }

    public static bool CheckIfGuessOnlyHasValidColors (string[] guess, string[] color)
    {
        int unmatchedColor = 0;
        for (int i = 0; i < guess.Length; i++)
        {
            for (int j = 0; j < color.Length; j++)
            {
                if (guess[i] == color[j])
                {
                    unmatchedColor = 0;
                    break;
                }
                else 
                {
                    unmatchedColor++;
                }
            }
        }
        
        if (unmatchedColor == 0)
        {
            // Checks if function correctly checks if all the color guesses are valid
            // Console.WriteLine("WOOOOO!");
            return true;
        }
        else
        {
            // Checks if function correctly outputs false when user tries to guess a nonvalid color
            // Console.WriteLine("BOOOOO!");
            return false;
        }
    }
}