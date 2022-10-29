using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class RookPiece : IPiece
{
	public RookPiece()
	{

	}

    public bool CanMoveToLocal()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♖";
    }
}

