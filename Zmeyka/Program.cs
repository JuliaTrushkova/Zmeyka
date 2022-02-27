// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;
using Zmeyka;


//Console.WindowHeight = 45;
//Console.WindowWidth = 85;
//Console.BufferHeight = Console.WindowHeight;
//Console.BufferWidth = Console.WindowWidth;

//int poleSizeX = Console.WindowWidth - 15;
//int poleSizeY = Console.WindowHeight - 5;

int poleSizeX = 80;
int poleSizeY = 40;
Console.WindowHeight = poleSizeY;
Console.WindowWidth = poleSizeX;

try
{
    while (true)
    {
        Console.Clear();

        Game newGame = new Game(poleSizeX, poleSizeY);
        newGame.ShowGameArea();

        Console.SetCursorPosition(0, 0);

        int sourceTop = newGame.Snake[0].Y;
        int sourceLeft = newGame.Snake[0].X;
        Item newStep = new Item(' ', sourceLeft, sourceTop);
        try
        {
           newGame.StartSnake();
            while (true)
            {
                newStep = GamePlay.Step(newStep.X, newStep.Y);

                newGame.WhatNewStep(newStep);
               // newGame.HigherSpeedSnake();
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
}
catch (Exception ex)
{
    //GamePlay.EndGame(ex.Message, newGame.PoleGame.PoleSizeX, newGame.PoleGame.PoleSizeY);
    //bool wantNewGame = GamePlay.QuitOrNewGame(newGame.PoleGame.PoleSizeX, newGame.PoleGame.PoleSizeY);
    //if (wantNewGame)
    //    continue;
    //else
    //    break;
    Console.WriteLine("ddd");
}
