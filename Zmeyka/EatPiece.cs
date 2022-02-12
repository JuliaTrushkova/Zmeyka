using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
    internal class EatPiece : Item
    {
        public EatPiece () : base()
        {

        }

        public EatPiece(char type, int x, int y) : base(type, x, y)
        {
           
        }

        public EatPiece(int x, int y) : base('$', x, y)
        {

        }
    }
}
