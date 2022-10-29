using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class QueenPiece : IPiece
{
	public QueenPiece()
	{

	}

	public bool CanMoveToLocal()
	{
		throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♛";
    }
}

