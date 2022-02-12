using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
    internal class Pole : ICompare
    {
        private Item[] _gameAreaBorder;

        public Pole(int lengthX, int lengthY)
        {
            int length = 2 * lengthX + 2 * (lengthY - 2);
            _gameAreaBorder = new Item[length];
            FillArea(lengthX, lengthY);
        }

        //Заполнение ячеек с границами поля по часовой стрелке начиная с верхнего левого угла
        private void FillArea(int lengthX, int lengthY)
        {
            //Вдоль ширины поля 
            for (int i = 0; i < lengthX; i++)
            {
                //Первая строка
                _gameAreaBorder[i] = new Item('-', i, 0);
                //Последняя строка
                _gameAreaBorder[lengthX + lengthY - 1 + i] = new Item('-', i, lengthY - 1);
            }

            //Вдоль высоты поля (за исключением двух ячеек снизу и сверху)
            for (int i = 0; i < lengthY - 2; i++)
            {
                //Первый столбец
                _gameAreaBorder[2 * lengthX + lengthY - 2 + i] = new Item('|', 0, i);
                //Последний столбец
                _gameAreaBorder[lengthX + i] = new Item('|', lengthX - 1, i + 1);
            }
        }
        /* 
        <summary> 
        Замена типа ячейки поля (например, рандомная точка еды)
        </summary>
        */

        //public void FillRandomEat(Item item)
        //{
        //    _gameAreaBorder[item.Y, item.X] = item.Type;
        //}

        //public void FillBySnake(Snake snake)
        //{
        //    for (int i = 0; i < snake.Count; i++)
        //        _gameAreaBorder[(int)snake[i].X, (int)snake[i].Y] = snake[i].Type;
        //}
    }
}
