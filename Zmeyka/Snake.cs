namespace Zmeyka
{
    internal class Snake : ItemArray<Item>
    {
       

        //По умолчанию змейка создастся в верхнм левом углу
        public Snake()
        {
            this._arrayT = new[]
            {
                new SnakeItem('@', 1, 2),
                new SnakeItem('#', 1, 1)
            };
        }

        //Создание змейки в рандомной точке поля
        public Snake(int poleSizeX, int poleSizeY)
        {
            this._arrayT = new Item[2];
            this._arrayT[0] = new SnakeItem(poleSizeX, poleSizeY);
            this._arrayT[1] = new SnakeItem('#', this._arrayT[0].X, this._arrayT[0].Y - 1);            
        }    

        /* 
        <summary> 
        Добавление ячейки в змею. Если HasEaten = false, то значит, что еды не было и длина змейки не увеличивается
        </summary>
        */
        public void AddItemToSnake(int newX, int newY, bool HasEaten)
        {
            //Добавление нового элемента
            this._arrayT[0].Type = '#';
            this._arrayT = this._arrayT.Prepend(new SnakeItem('@', newX, newY)).ToArray();
            this._arrayT[0].ShowItem();
            this._arrayT[1].ShowItem();
            //Если змейка не ела, то после добавления нового элемента удаляем с конца элемент
            if (!HasEaten)
            {
                this._arrayT.Last().Type = ' ';
                this._arrayT.Last().ShowItem();
                this._arrayT = this._arrayT.SkipLast(1).ToArray();
            }
        }
    }
}
    }
}
