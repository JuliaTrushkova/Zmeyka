namespace Zmeyka
{
    internal class EatPiece : Item
    {
        public EatPiece() : base()
        {
            this.Type = '$';
        }

        public EatPiece(int poleSizeX, int poleSizeY) : base(poleSizeX, poleSizeY)
        {           
            this.Type = '$';
        }
    }
}
