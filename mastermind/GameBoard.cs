namespace mastermind;

class GameBoard {

/* What is the gameboard class in charge of?
    1. Displaying the game board
*/

    public static string[,] board = new string[8,8];
    public static void PrintBoard() {
        Console.WriteLine("|============================================|");
        Console.WriteLine("|                 MASTERMIND                 |");
        Console.WriteLine("|============================================|");
        Console.WriteLine("| Guesses:                                   |");
    }

    // Print results in GameMaintenance handles the board updating
    public static void UpdateBoard (string[] guess, string[] results, int currentTurn) 
    {
        string[] holderArray = guess.Concat(results).ToArray();
        for (int i = 0; i < 8; i++)
        {
            board[currentTurn, i] = holderArray[i];
        }
        for (int j = 0; j <= currentTurn; j++)
        {
            Console.Write("|  ");
            for (int l = 0; l < 8; l++)
            {
                Console.Write($"| {board[j, l]} |");
            }
            Console.Write("  |");
            Console.WriteLine("");
            Console.WriteLine("|============================================|");
        }
        
        // for (int i = 0; i <= currentTurn; i++)
        // {
        //     for (int k = 0; k < guess.Length; k++)
        //     {
        //         try {
        //             board[currentTurn, k] = guess[k];
        //         } catch (Exception e) {
        //             Console.WriteLine(e.Message + " Guess array not correctly captured");
        //         }
        //     }
        //     for (int j = 0; j < results.Length; j++)
        //     {
        //         try {
        //             board[currentTurn, j + 4] = results[j];
        //         } catch (Exception e) {
        //             Console.WriteLine(e.Message + " Guess array not correctly captured");
        //         }
        //     }
        //     for (int l = 0; l < 8; l++)
        //     {
        //         Console.Write($"| {board[currentTurn, l]} |");
        //     }
        //     Console.WriteLine("");
        // }   
    }
}