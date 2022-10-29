using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class PawnPiece : IPiece
{
	public PawnPiece()
	{

	}

    public bool CanMoveToLocal()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♙";
    }
}

