using System;
using System.Numerics;
using Chess.Model;

namespace Chess.EightQueens.Extensions;

public static class CountQueensExtensions
{
    public static int CountQueens(this Board board)
    {
        var size = board.SquadSize;
        var slots = board.Slots;
        int count = 0;

        for (int x = 0; x < size; x++)
            for (int y = 0; y < size; y++)
                if (slots[x, y].Content is QueenPiece)
                    count++;

        return count;
    }

    public static void WriteQueenCount(this Board board)
    {
        int queenCount = board.CountQueens();

        if (queenCount > 4)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (queenCount == 8)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.WriteLine($"Queen count: {queenCount}");
    }
}

