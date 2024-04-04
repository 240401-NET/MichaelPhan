namespace mastermind;

class GameBoard {

/* What is the gameboard class in charge of?
    1. Displaying the game board
*/

    int[] board = new int[8];
public static void PrintBoard() {
    Console.WriteLine("|===========================================|");
    Console.WriteLine("|                MASTERMIND                 |");
    Console.WriteLine("|===========================================|");
    Console.WriteLine("|Guesses:                                   |");
}

}