using System;
namespace Chess.EightQueens.Model;

public class Slot
{
    public SlotContent Content { get; set; }

    public string ShowContent(bool basicColor = false)
    {
        if (basicColor)
            Console.ForegroundColor = ConsoleColor.Gray;

        switch (Content)
        {
            case SlotContent.Empty:
                if (!basicColor)
                    Console.ForegroundColor = ConsoleColor.Green;
                return "-";

            case SlotContent.Queen:
                if (!basicColor)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                return "♛";

            case SlotContent.EmptyButDangerous:
                if (!basicColor)
                    Console.ForegroundColor = ConsoleColor.Red;
                return "-";

            default:
                return " ";
        }
    }
}

public enum SlotContent
{
    Empty,
    EmptyButDangerous,
    Queen,
}