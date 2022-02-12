// See https://aka.ms/new-console-template for more information
using Zmeyka;


Console.WriteLine("Hello, World! \ntrololololooloo\ntrololololooloo" +
    "\ntrololololooloo\ntrololololooloo\ntrololololooloo\ntrololololooloo" +
    "\ntrololololooloo\ntrololololooloo\ntrololololooloo\ntrololololooloo" +
    "\ntrololololooloo\ntrololololooloo\ntrololololooloo");

Console.SetCursorPosition(6, 3);

Console.Write('6');

Console.SetCursorPosition(0, 0);

int sourceTop = 0;
int sourceLeft = 0;
int targetTop = 10;
int targetLeft = 10;

ChangePosition(sourceTop, sourceLeft, targetTop, targetLeft);

//Console.WriteLine("The current buffer height is {0} rows.",
//Console.BufferHeight);
//Console.WriteLine("The current buffer width is {0} columns.",
//Console.BufferWidth);
while (true)
{
    ConsoleKeyInfo keyPress = Console.ReadKey();

    switch (keyPress.Key)
    {
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            ChangePosition(targetTop, targetLeft, ++targetTop, targetLeft);
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            ChangePosition(targetTop, targetLeft, targetTop, ++targetLeft);
            break;
        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            ChangePosition(targetTop, targetLeft, targetTop, --targetLeft);
            break;
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            ChangePosition(targetTop, targetLeft, --targetTop, targetLeft);
            break;
    }
}

static void ChangePosition(int sourceTop, int sourceLeft, int targetTop,int targetLeft)
{
    int sourceWidth = 13;
    int sourceHeight = 1;
    Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight,
            targetLeft, targetTop, ' ', ConsoleColor.Green, ConsoleColor.Red);
}
