using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
    internal class Snake : ICompare
    {
        private SnakeItem[] _zmeykaItems;

        //По умолчанию змейка создастся в верхнм левом углу
        public Snake()
        {
            _zmeykaItems = new[]
            {
                new SnakeItem('@', 1, 2),
                new SnakeItem('#', 1, 1)
            };
        }

        //Создание змейки в рандомной точке поля
        public Snake(int randomX, int randomY)
        {
            _zmeykaItems = new[]
            {
                new SnakeItem('@', randomX, randomY),
                new SnakeItem('#', randomX, --randomY)
            };
        }

        public int Count
            => _zmeykaItems.Length;

        public SnakeItem this[int index]
        {
            get
            {
                if (index>=0&& index<_zmeykaItems.Length)
                    return _zmeykaItems[index];
                else 
                    throw new Exception("Index too much for snake");
            }
            set 
            {
                if (index >= 0 && index < _zmeykaItems.Length)
                    _zmeykaItems[index] = value;
                else
                    throw new Exception("Index too much for snake");
            }
        }

        /* 
        <summary> 
        Добавление ячейки в змею. Если HasEaten = false, то значит, что еды не было и длина змейки не увеличивается
        </summary>
        */
        public void AddItemToSnake(int newX, int newY, bool HasEaten)
        {
            _zmeykaItems[0].Type = '#';
            _zmeykaItems.Prepend(new SnakeItem('@', newX, newY));
            if (!HasEaten)
                _zmeykaItems.SkipLast(1);
        }
    }
}
