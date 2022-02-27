namespace Zmeyka
{
    internal class Item
    {
        private char _type;
        private int _x;
        private int _y;

        public Item(char type, int x, int y)
        {
            _type = type;
            _x = x;
            _y = y;
        }

        public Item(int poleSizeX, int poleSizeY)
        {
            Random random = new Random();
            int randomX = random.Next(1, poleSizeX - 1);
            int randomY = random.Next(2, poleSizeY - 1);
            _type = 'i';
            _x = randomX;
            _y = randomY;
        }

        public Item()
        {
            _type = ' ';
            _x = 0;
            _y = 0;
        }

        public char Type
        {
            get => _type;
            set => _type = value;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public void ShowItem()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.Type);
        }

        public bool Equal(Item item1)
        {
            if (item1.X == this.X && item1.Y == this.Y)
                return true;
            else
                return false;
        }
    }
}
