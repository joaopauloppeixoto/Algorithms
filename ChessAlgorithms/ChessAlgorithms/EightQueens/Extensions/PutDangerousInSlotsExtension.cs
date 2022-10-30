using System;
using System.Drawing;
using System.Numerics;
using Chess.Model;

namespace Chess.EightQueens.Extensions;

public static class PutDangerousInSlotsExtension
{
    public static void PutQueenDangerousInSlots(this Board board, Vector2 position)
    {
        var size = board.SquadSize;
        var slots = board.Slots;

        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                var actualSlot = slots[(int)position.X, (int)position.Y];
                var slot = slots[x, y];

                if (actualSlot.Content?.CanMoveToLocal(position, new Vector2(x, y), size) ?? false)
                    slot.IsDangerous = true;
            }
        }
    }
}
