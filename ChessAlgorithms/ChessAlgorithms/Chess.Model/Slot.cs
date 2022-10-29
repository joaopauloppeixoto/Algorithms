using System;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class Slot
{
    public bool IsEmpty { get { return Content == null; } }
    public bool IsDangerous { get; set; } = false;
    public IPiece? Content { get; set; } = null;

    public override string ToString()
    {
        return Content?.ToString() ?? " ";
    }
}
