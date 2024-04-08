namespace mastermind;

class Player {

    public string? name {get; set;}
    public string? nickname {get; set;}
    public int? totalSolves {get; set;}
    public Dictionary<string, int>? previousSolutions {get; set;}


    //constructor for Player Class
    public Player () {}

    public Player(Dictionary<string, int> previousSolutions) 
    {
        this.previousSolutions = previousSolutions;
    }
    public Player(string name, string nickname) 
    {
        this.name = name;
        this.nickname = nickname;
    }
    public Player(string name, string nickname, Dictionary<string, int> previousSolutions) 
    {
        this.name = name;
        this.nickname = nickname;
        this.previousSolutions = previousSolutions;
    }

    public static Dictionary<string,int> GenerateSolvesList (string code, int turnsTaken, Dictionary<string,int> solutions)
    {
        solutions.Add(code, turnsTaken);
        return solutions;
    }

    public void Printout ()
    {
        string output = $"Amazing {name}, you have beated Mastermind a tolal of : {GameMaster.previousSolutions.Count} times ";
        output += $"If you want to view all your previous solves, please visit the leaderboard option on the main menu";
        Console.WriteLine(output);
    }

    public static void PrintDictionary(Dictionary<string, int> solutions)
    {
        foreach (KeyValuePair<string, int> pair in solutions)
        {
        Console.WriteLine("The code was: {0} and you took {1} turns to solve it.", pair.Key, pair.Value);
        }
    }
}

