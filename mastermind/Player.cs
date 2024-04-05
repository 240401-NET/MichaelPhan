namespace mastermind;

class Player {

/* What describes a Player class in this game?
    1. A unique id for each Player that has played the game
    2. Name
    3. Nickname
    4. List of previous solves/solutions
*/
    public string? name {get; set;}
    public string? nickname {get; set;}
    public List<PreviousSolutions> previousSolutions = new();


    //constructor for Player Class
    public Player () {}

    public Player(string name, string nickname, List<PreviousSolutions> previousSolutions) {
        this.name = name;
        this.nickname = nickname;
        this.previousSolutions = previousSolutions;
    }
}

