using System;
using System.Drawing;
using System.Numerics;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class QueenPiece : IPiece
{
	public QueenPiece()
	{

	}

	public bool CanMoveToLocal(Vector2 originalPosition, Vector2 destinyPosition, int squadSize)
    {
        var originalX = (int)originalPosition.X;
        var originalY = (int)originalPosition.Y;

        if (originalX == destinyPosition.X || originalY == destinyPosition.Y)
            return true;

        int row = 0;
        int col = originalY - originalX;

        while (row < 0 || col < 0)
        {
            row++;
            col++;
        }

        while (row < 8 && col < 8)
        {
            if (row == destinyPosition.X && col == destinyPosition.Y)
                return true;

            row++;
            col++;
        }

        row = originalY + originalX;
        col = 0;

        while (row > 7 || col > 7)
        {
            row--;
            col++;
        }

        while (row >= 0 && col < 8)
        {
            if (row == destinyPosition.X && col == destinyPosition.Y)
                return true;

            row--;
            col++;
        }

        return false;
    }

    public override string ToString()
    {
        return "♦";
    }
}

