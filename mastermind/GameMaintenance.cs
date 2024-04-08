using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using System.Linq;
namespace mastermind;

class GameMaintenance {
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
        Console.WriteLine("");
        Console.WriteLine("Please enter your 4-color code using the letters R, G, B, Y, O, and P");
        string guess = Console.ReadLine()!.ToUpper();
        return guess;
    }

    public static string[] ConvertGuessToArray (string guess) {
        string[] guessArray = guess.Split(" ");
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
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string[] CompareGuessToSecretCode (string[] guess, string[] code)
    {
        string[] results = new string[4];
        string[] codeCopy = new string[4];
        code.CopyTo(codeCopy, 0);
        for (int i = 0; i < guess.Length; i++)
        {
            if(guess[i] == codeCopy[i])
            {
                results[i] = "+";
                codeCopy[i] = "0";
            }
        }

        for (int j = 0; j < guess.Length; j++)
        {
            if(codeCopy.Contains(guess[j]) && results[j] !="+")
            {
                results[j] = "*";
                codeCopy[Array.IndexOf(code, guess[j])] = "0";
            }    
        }

        for (int k = 0; k < guess.Length; k++)
        {
            if(!code.Contains(guess[k]))
            {
                results[k] = "-";
                codeCopy[k] = "0";
            }
        }
        return results;
    }

    public static bool CheckForWin(string[] results) {
        string[] winningArray = ["+", "+", "+", "+"];
        bool isEqual = results.SequenceEqual(winningArray);
        return isEqual;
    }
}