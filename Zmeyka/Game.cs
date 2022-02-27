namespace Zmeyka
{
    internal class Game
    {
        private object block = new object();
        private Pole _poleGame;
        private Snake _snake;
        private EatPiece _eatPiece;
        private Timer _timer;

        public Game(int poleSizeX, int poleSizeY)
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
        public Timer TimerForSnake => _timer;

        public void ShowGameArea()
        {
            _poleGame.ShowItems();
            _snake.ShowItems();
            _eatPiece.ShowItem();

        }

        public void WhatNewStep(Item newStep)
        {
            try
            {
                lock (block)
                {
                    if (_snake.Contains(newStep) || _poleGame.Contains(newStep))
                    {
                       
                        throw new Exception("GAME OVER");
                    }
                    else if (_eatPiece.Equal(newStep))
                    {
                        _snake.AddItemToSnake(newStep.X, newStep.Y, true);
                        this.GetEatPeace(_poleGame.PoleSizeX, _poleGame.PoleSizeY);
                        _eatPiece.ShowItem();
                    }
                    else
                    {
                        _snake.AddItemToSnake(newStep.X, newStep.Y, false);
                    }

                    if (_snake.Count == _poleGame.PoleArea)
                    {
                       
                        throw new Exception("YOU WIN");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void StartSnake()
        {
            try
            {
                // создаем таймер
                TimerCallback timerDelegate = new TimerCallback(this.AutoStepSnake);
                _timer = new Timer(timerDelegate, _snake, 0, _snake.TimerInterval);                
            }
            catch (Exception e)
            {
                throw new Exception("StartSnake", e);
            }
        }

        public void AutoStepSnake(object snake)
        {
            try
            {
                if (!Console.IsInputRedirected && !Console.IsOutputRedirected)
                {
                    
                    Item newStep = _snake.StepToDirection();
                    this.WhatNewStep(newStep);
                }
            }
            catch (Exception e)
            {
                StopSnake();
                throw new Exception("AutoStepSnake", e);
            }
        }

        public void StopSnake()
        {
            _timer.Dispose();
        }

        public void HigherSpeedSnake()
        {
            _snake.ChangeTimeInterval();
            _timer.Change(0, _snake.TimerInterval);
        }
    }
}
