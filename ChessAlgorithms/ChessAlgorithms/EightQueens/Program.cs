using Chess.EightQueens.Model;

var board = new Board();
var random = new Random();
var restartCount = 0;

while (board.countQueens() < 8)
{
    var avaiablePositions = board.GetAvaiablePositions();
    if (avaiablePositions.Count() > 0)
    {
        var randomPosition = avaiablePositions[random.Next(0, avaiablePositions.Count())];
        board.PutQueen(randomPosition);
    } else
    {
        board.RestartBoard();
        restartCount++;
    }
    board.PrintBoardOnConsole(true);
    Console.WriteLine($"Restart count: {restartCount}\n");
}
