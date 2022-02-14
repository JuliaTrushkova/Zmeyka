namespace Zmeyka
{
    internal class Game
    {
        private Pole _poleGame;
        private Snake _snake;
        private EatPiece _eatPiece;

        public Game (int poleSizeX, int poleSizeY)
        {
            _poleGame = new Pole(poleSizeX, poleSizeY);
            _snake = new Snake(poleSizeX, poleSizeY);
            GetEatPeace(poleSizeX, poleSizeY);
        }

        public void GetEatPeace(int poleSizeX, int poleSizeY)
        {
            do
            {
                _eatPiece = new EatPiece(poleSizeX, poleSizeY);
            } while (_snake.Contains(_eatPiece));
        }


        public Pole PoleGame => _poleGame; 
        public Snake Snake => _snake;
        public EatPiece EatPiece => _eatPiece;
        
        public void ShowGameArea()
        {
            _poleGame.ShowItems();
            _snake.ShowItems();
            _eatPiece.ShowItem();
        }



    }
}
