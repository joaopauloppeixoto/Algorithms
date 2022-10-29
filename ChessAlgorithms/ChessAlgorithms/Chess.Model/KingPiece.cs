using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class KingPiece : IPiece
{
	public KingPiece()
	{

	}

    public bool CanMoveToLocal()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♔";
    }
}

