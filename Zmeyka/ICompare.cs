using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
    internal interface ICompare : I
    {
        public bool Equal(Item item1, Item item2)
        {
            if (item1.X == item2.X && item1.Y == item2.Y)
                return true;
            else
                return false;
        }

        public bool Contains(Item item, Item[] itemsArray)
        {
            for (int i = 0; i < itemsArray.Length; i++)
                if (Equals(itemsArray[i],item))
                    return true;
            return false;
        }
    }
}
