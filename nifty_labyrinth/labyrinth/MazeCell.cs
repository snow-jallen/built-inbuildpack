namespace labyrinth;

public enum Item
{
    Nothing,
    Spellbook,
    Potion,
    Wand
}

/**
 * Type representing a cell in a maze.
 */ 
public class MazeCell
{
    public MazeCell()
    {
        Id = NextCellId++;
    }

    public int Id { get; }
    public Item WhatsHere { get; set; }
    public MazeCell? North { get; set; } = null;
    public MazeCell? South { get; set; } = null;
    public MazeCell? East { get; set; } = null;
    public MazeCell? West { get; set; } = null;

    public override string ToString()
    {
        var symbol = WhatsHere switch
        {
            Item.Potion => " ⚗",
            Item.Spellbook => " 🕮",
            Item.Wand => " ⚚",
            _ => ""
        };

        return $"{Id}{symbol}";
    }

    // public override bool Equals(object? obj)
    // {
    //     return obj is MazeCell cell &&
    //            Id == cell.Id &&
    //            WhatsHere == cell.WhatsHere;
    // }

    // public override int GetHashCode()
    // {
    //     return HashCode.Combine(Id, WhatsHere, North?.Id, South?.Id, East?.Id, West?.Id);
    // }

    private static int NextCellId = 0;
}
