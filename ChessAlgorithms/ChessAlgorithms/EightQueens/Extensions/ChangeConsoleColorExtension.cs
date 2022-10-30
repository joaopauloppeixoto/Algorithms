using System;
using System.Reflection.Metadata;
using Chess.Model;

namespace Chess.EightQueens.Extensions;

public static class ChangeConsoleColorExtension
{
    public static void ChangeBackgroundColor(this Slot slot, int backgroundColorCount = -1)
    {
        if (backgroundColorCount != -1)
        {
            Console.BackgroundColor = backgroundColorCount % 2 == 0 ? ConsoleColor.Gray : ConsoleColor.DarkGray;
        }
    }

    public static void ChangeForegroundColor(this Slot slot)
    {
        if (slot.IsEmpty)
        {
            Console.ForegroundColor = slot.IsDangerous ? ConsoleColor.DarkRed : ConsoleColor.DarkGreen;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}




