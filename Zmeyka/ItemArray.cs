namespace Zmeyka
{
    internal class ItemArray<T> where T : Item
    {
        public T[] _arrayT;

        public ItemArray()
        {
            _arrayT = new T[] {};
        }

        public int Count
            => _arrayT.Length;

        public void ShowItems()
        {
            for (int i = 0; i < _arrayT.Length; i++)
            {
                _arrayT[i].ShowItem();
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _arrayT.Length)
                    return _arrayT[index];
                else
                    throw new Exception("Index too much for snake");
            }
            set
            {
                if (index >= 0 && index < _arrayT.Length)
                    _arrayT[index] = value;
                else
                    throw new Exception("Index too much for snake");
            }
        }        

        public bool Contains(T item)
        {
            for (int i = 0; i < _arrayT.Length; i++)
                if (_arrayT[i].Equal(item))
                    return true;
            return false;
        }
    }
}
