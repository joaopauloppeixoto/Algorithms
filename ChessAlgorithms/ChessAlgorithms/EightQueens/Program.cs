using Chess.EightQueens.Extensions;
using Chess.Model;

var board = new Board();
var random = new Random();
var restartCount = 0;

while (board.CountQueens() < 8)
{
    var avaiablePositions = board.GetAvaiablePositions();
    if (avaiablePositions.Count() > 0)
    {
        var randomPosition = avaiablePositions[random.Next(0, avaiablePositions.Count())];
        board.PutPiece(randomPosition, new QueenPiece());
        board.PutQueenDangerousInSlots(randomPosition);
    } else
    {
        board.RestartBoard();
        restartCount++;
    }

    board.PrintBoardOnConsole();
    board.WriteQueenCount();

    Console.WriteLine($"Restart count: {restartCount}");
}
