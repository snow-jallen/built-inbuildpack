using labyrinth;

namespace ui;

public class MazeLink
{
    public MazeLink(MazeCell cell1, MazeCell cell2, string label)
    {
        Cell1 = cell1;
        Cell2 = cell2;
        Label = label;
    }
    public MazeCell Cell1 { get; set; }
    public MazeCell Cell2 { get; set; }
    public String Label { get; set; }
    public override int GetHashCode()
    {
        return HashCode.Combine(Cell1, Cell2);
    }

    public override bool Equals(object obj)
    {
        return obj is MazeLink link &&
        (
        (link.Cell1.Equals(Cell1) && link.Cell2.Equals(Cell2))
        );
    }

    public override string ToString()
    {
        var cell1Symbol = Cell1.WhatsHere switch
        {
            Item.Potion => " Potion",
            Item.Spellbook => " Spellbook",
            Item.Wand => " Wand",
            _ => ""
        };
        var cell2Symbol = Cell2.WhatsHere switch
        {
            Item.Potion => " Potion",
            Item.Spellbook => " Spellbook",
            Item.Wand => " Wand",
            _ => ""
        };
        return $"{Cell1.Id}[{Cell1.Id} {cell1Symbol}] -- {Label} --> {Cell2.Id}[{Cell2.Id} {cell2Symbol}]\n";
    }

}