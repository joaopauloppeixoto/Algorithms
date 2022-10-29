using System;
using System.Numerics;
using Chess.Model;

namespace Chess.EightQueens.Extensions;

public static class PutDangerousInSlotsExtension
{
    public static void PutQueenDangerousInSlots(this Board board, Vector2 position)
    {
        var size = board.SquadSize;
        var slots = board.Slots;
        var x = (int) position.X;
        var y = (int) position.Y;

        for (int z = 0; z < size; z++)
        {
            if (slots[x, z].IsEmpty)
            {
                slots[x, z].IsDangerous = true;
            }
        }
        for (int z = 0; z < size; z++)
        {
            if (slots[z, y].IsEmpty)
            {
                slots[z, y].IsDangerous = true;
            }
        }

        int row = 0;
        int col = y - x;

        while (row < 0 || col < 0)
        {
            row++;
            col++;
        }

        while (row < 8 && col < 8)
        {
            if (slots[row, col].IsEmpty)
                slots[row, col].IsDangerous = true;

            row++;
            col++;
        }

        row = y + x;
        col = 0;

        while (row > 7 || col > 7)
        {
            row--;
            col++;
        }

        while (row >= 0 && col < 8)
        {
            if (slots[row, col].IsEmpty)
                slots[row, col].IsDangerous = true;

            row--;
            col++;
        }
    }
}

