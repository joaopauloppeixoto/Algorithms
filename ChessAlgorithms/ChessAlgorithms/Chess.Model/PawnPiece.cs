using System;
using System.Numerics;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class PawnPiece : IPiece
{
	public PawnPiece()
	{

	}

    public bool CanMoveToLocal(Vector2 originalPosition, Vector2 destinyPosition, int squadSize)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♙";
    }
}

