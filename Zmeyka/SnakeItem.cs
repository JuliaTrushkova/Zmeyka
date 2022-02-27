namespace Zmeyka
{
    internal class SnakeItem : Item
    {
        public SnakeItem() : base()
        {

        }

        public SnakeItem(char type, int x, int y) : base(type, x, y)
        {

        }

        public SnakeItem(int poleSizeX, int poleSizeY) : base(poleSizeX, poleSizeY)
        {
            Type = '@';
        }
    }
}
