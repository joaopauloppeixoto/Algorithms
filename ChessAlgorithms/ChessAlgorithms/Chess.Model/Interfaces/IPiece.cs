using System.Numerics;

namespace Chess.Model.Interfaces;

public interface IPiece
{
    public bool CanMoveToLocal(Vector2 originalPosition, Vector2 destinyPosition, int squadSize);
}

