using System;
using System.Numerics;
using Chess.Model;

namespace Chess.EightQueens.Extensions;

public static class PrintBoardOnConsoleExtension
{
    public static void PrintBoardOnConsole(this Board board)
    {
        var size = board.SquadSize;
        var Slots = board.Slots;

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("-----\n");
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                board.Slots[x, y].ChangeForegroundColor();
                board.Slots[x, y].ChangeBackgroundColor(x + y);
                Console.Write($"{Slots[x, y]} ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine();
        }
    }
}

