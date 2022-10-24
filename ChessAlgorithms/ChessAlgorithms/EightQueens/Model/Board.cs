using System;
using System.Numerics;

namespace Chess.EightQueens.Model;

public class Board
{
    public Slot[,] Slots { get; set; }
    private int SquadSize { get; set; }

    public Board(int squadSize = 8)
    {
        SquadSize = squadSize;
        Slots = new Slot[squadSize, squadSize];
        RestartBoard();
    }

    public void RestartBoard()
    {
        for (int x = 0; x < SquadSize; x++)
        {
            for (int j = 0; j < SquadSize; j++)
            {
                Slots[x, j] = new Slot();
            }
        }
    }

    public void PrintBoardOnConsole(bool showVariables = false)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("-----\n");
        for (int x = 0; x < SquadSize; x++)
        {
            for (int y = 0; y < SquadSize; y++)
            {
                Console.Write($"{Slots[x, y].ShowContent()} ");
            }
            Console.WriteLine();
        }

        if (showVariables)
        {
            int queenCount = countQueens();

            if (queenCount > 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (queenCount == 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"\nQueen count: {queenCount}\n");
        }
    }

    public void PutQueen(Vector2 position)
    {
        var x = (int)position.X;
        var y = (int)position.Y;

        Slots[x, y].Content = SlotContent.Queen;

        for (int z = 0; z < SquadSize; z++)
        {
            if (Slots[x, z].Content == SlotContent.Empty)
            {
                Slots[x, z].Content = SlotContent.EmptyButDangerous;
            }
        }
        for (int z = 0; z < SquadSize; z++)
        {
            if (Slots[z, y].Content == SlotContent.Empty)
            {
                Slots[z, y].Content = SlotContent.EmptyButDangerous;
            }
        }

        int row = 0;
        int col = y - x;

        while (row < 0 || col < 0)
        {
            row++;
            col++;
        }


        while (row < 8 && col < 8)
        {
            if (Slots[row, col].Content == SlotContent.Empty)
            {
                Slots[row, col].Content = SlotContent.EmptyButDangerous;
            }
            row++;
            col++;
        }

        row = y + x;
        col = 0;


        while (row > 7 || col > 7)
        {
            row--;
            col++;
        }


        while (row >= 0 && col < 8)
        {
            if (Slots[row, col].Content == SlotContent.Empty)
            {
                Slots[row, col].Content = SlotContent.EmptyButDangerous;
            }
            row--;
            col++;
        }
    }

    public int countQueens()
    {
        int count = 0;

        for (int x = 0; x < SquadSize; x++)
            for (int y = 0; y < SquadSize; y++)
                if (Slots[x, y].Content == SlotContent.Queen)
                    count++;

        return count;
    }

    public IList<Vector2> GetAvaiablePositions()
    {
        var avaiablePositions = new List<Vector2>();

        for (int x = 0; x < SquadSize; x++)
            for (int y = 0; y < SquadSize; y++)
                if (Slots[x, y].Content == SlotContent.Empty)
                    avaiablePositions.Add(new Vector2(x, y));

        return avaiablePositions;
    }
}

