using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Item(int x, int y)
        {
            _type = ' ';
            _x = x;
            _y = y;
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
    }
}
