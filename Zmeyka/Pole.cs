namespace Zmeyka
{
    internal class Pole : ItemArray<Item>
    {
        public int PoleArea { get; }
        public int PoleSizeX { get; }
        public int PoleSizeY { get; }

        public Pole(int lengthX, int lengthY)
        {
            int length = 2 * lengthX + 2 * (lengthY - 2);
            this._arrayT = new Item[length];
            FillArea(lengthX, lengthY);
            PoleArea = lengthX * lengthY - length;
            PoleSizeX = lengthX;
            PoleSizeY = lengthY;
        }

        //Заполнение ячеек с границами поля по часовой стрелке начиная с верхнего левого угла.
        //0 1 2
        //7   3
        //6 5 4 
        private void FillArea(int lengthX, int lengthY)
        {
            //Вдоль ширины поля 
            for (int i = 0; i < lengthX; i++)
            {
                //Первая строка
                this._arrayT[i] = new Item('-', i, 0);
                //Последняя строка
                this._arrayT[lengthX + lengthY - 2 + i] = new Item('-', lengthX - 1 - i, lengthY - 1);
            }

            //Вдоль высоты поля (за исключением двух ячеек снизу и сверху)
            for (int i = 0; i < lengthY - 2; i++)
            {
                //Первый столбец
                this._arrayT[2 * lengthX + lengthY - 2 + i] = new Item('|', 0, i + 1);
                //Последний столбец
                this._arrayT[lengthX + i] = new Item('|', lengthX - 1, i + 1);
            }
        }
    }
}
