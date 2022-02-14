namespace Zmeyka
{
    internal static class GamePlay
    {
        //Получение координат ячейки, куда должна пойти змейка после нажатия кнопки
        public static Item Step(int sourceLeft, int sourceTop)
        {
            ConsoleKeyInfo keyPress = Console.ReadKey();
            switch (keyPress.Key)
            {
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    ++sourceTop;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    ++sourceLeft;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    --sourceLeft;
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    --sourceTop;
                    break;
                case ConsoleKey.Escape:
                    throw new Exception("_EXIT GAME");
                    break;
            }
            return new Item(' ', sourceLeft, sourceTop);
        }

        //Конец игры 
        public static void EndGame(string text, int X, int Y)
        {
            ConsoleColor color = ConsoleColor.Gray;
            switch (text)
            {
                case "_EXIT GAME":
                    color = ConsoleColor.Blue;
                    break;
                case "YOU WIN":
                    color = ConsoleColor.Green;
                    break;
                case "GAME OVER":
                default:
                    color = ConsoleColor.DarkRed;
                    break;
            }
            Console.SetCursorPosition(X / 2, Y / 2);
            Show(text, color);                  
        }

        //Запрос: хочет ли игрок выйти из игры или начать новую
        public static bool QuitOrNewGame(int X, int Y)
        {
            Console.SetCursorPosition(X / 2, Y / 2 + 1);
            bool newGame = false;
            Show("NEW GAME? Y/N", ConsoleColor.DarkCyan);
            ConsoleKeyInfo keyPress = Console.ReadKey();
            if (keyPress.Key == ConsoleKey.Y || keyPress.Key == ConsoleKey.Enter)
                newGame = true;
            return newGame;
        }

        //Вывод на экран текста
        public static void Show(string text, ConsoleColor color)
        {            
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
