using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Goblin: Enemy
    {
        public Goblin(int x,int y)
            :base(x,y,1,10,'G')
        {
            this.y = y;
            this.x = x;
        }

        public override Movement ReturnMove(Movement direction)
        {
            Random r = new Random();

            return direction;
        }

    }
}
