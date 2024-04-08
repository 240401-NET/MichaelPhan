namespace mastermind;

class Player {

    public string? name {get; set;}
    public string? nickname {get; set;}
    public int? totalSolves {get; set;}
    public static Dictionary<string, int> previousSolutions = new Dictionary<string, int>();


    //constructor for Player Class
    public Player () {}

    public Player(string name, string nickname, List<KeyValuePair<string, int>> previousSolutions) 
    {
        this.name = name;
        this.nickname = nickname;
    }

    public static Dictionary<string,int> GenerateSolvesList (string code, int turnsTaken)
    {
        previousSolutions.Add(code, turnsTaken);
        return previousSolutions;
    }

    public static void PrintDictionary()
    {
        foreach (KeyValuePair<string, int> pair in previousSolutions)
        {
        Console.WriteLine("Total key/value pairs in"+ 
                " myDict are : " + previousSolutions.Count);
        Console.WriteLine("The code was: {0} and you took {1} turns to solve it.", pair.Key, pair.Value);
        }
    }
}

