using System;
using System.Numerics;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class RookPiece : IPiece
{
	public RookPiece()
	{

	}

    public bool CanMoveToLocal(Vector2 originalPosition, Vector2 destinyPosition, int squadSize)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♖";
    }
}

