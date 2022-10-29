using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class HorsePiece : IPiece
{
    public HorsePiece()
    {

    }

    public bool CanMoveToLocal()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "♘";
    }
}

