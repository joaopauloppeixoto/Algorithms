using System;
using System.Numerics;
using Chess.Model;
using Chess.Model.Interfaces;

namespace Chess.Model;

public class Board
{
    public Slot[,] Slots { get; set; }
    public int SquadSize { get; set; }

    public Board(int squadSize = 8)
    {
        SquadSize = squadSize;
        Slots = new Slot[squadSize, squadSize];
        RestartBoard();
    }

    public void RestartBoard()
    {
        for (int x = 0; x < SquadSize; x++)
            for (int j = 0; j < SquadSize; j++)
                Slots[x, j] = new Slot();
    }

    public void PutPiece(Vector2 position, IPiece piece)
    {
        var x = (int)position.X;
        var y = (int)position.Y;

        Slots[x, y].Content = piece;
    }

    public IList<Vector2> GetAvaiablePositions()
    {
        var avaiablePositions = new List<Vector2>();

        for (int x = 0; x < SquadSize; x++)
            for (int y = 0; y < SquadSize; y++)
                if (Slots[x, y].IsEmpty && !Slots[x, y].IsDangerous)
                    avaiablePositions.Add(new Vector2(x, y));

        return avaiablePositions;
    }
}

