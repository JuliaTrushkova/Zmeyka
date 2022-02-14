// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;
using Zmeyka;

#pragma warning disable CA1416 // Validate platform compatibility
Console.WindowHeight = 55;
Console.WindowWidth = 115;
#pragma warning restore CA1416 // Validate platform compatibility

int poleSizeX = 100;
int poleSizeY = 50;

while (true)
{
    Console.Clear();

    Game newGame = new Game(poleSizeX, poleSizeY);
    newGame.ShowGameArea();

    Console.SetCursorPosition(0, 50);

    int sourceTop = newGame.Snake[0].Y;
    int sourceLeft = newGame.Snake[0].X;
    Item newStep = new Item(' ', sourceLeft, sourceTop);
    try
    {

        while (true)
        {
            newStep = GamePlay.Step(newStep.X, newStep.Y);

            if (newGame.Snake.Contains(newStep) || newGame.PoleGame.Contains(newStep))
                throw new Exception("GAME OVER");
            else if (newGame.EatPiece.Equal(newStep))
            {
                newGame.Snake.AddItemToSnake(newStep.X, newStep.Y, true);
                newGame.GetEatPeace(newGame.PoleGame.PoleSizeX, newGame.PoleGame.PoleSizeY);
                newGame.EatPiece.ShowItem();
            }
            else
            {
                newGame.Snake.AddItemToSnake(newStep.X, newStep.Y, false);
            }

            if (newGame.Snake.Count == newGame.PoleGame.PoleArea)
                throw new Exception("YOU WIN"); 
        }
    }
    catch (Exception ex)
    {        
        GamePlay.EndGame(ex.Message, newGame.PoleGame.PoleSizeX, newGame.PoleGame.PoleSizeY);
        bool wantNewGame = GamePlay.QuitOrNewGame(newGame.PoleGame.PoleSizeX, newGame.PoleGame.PoleSizeY);
        if (wantNewGame)
            continue;
        else
            break;
    }
}

