using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Tile
    {
        protected int x, y;

        public enum TileType
        {
            Hero = 0, Enemy = 1, Gold = 2, Weapon = 3
        }

        public Tile(int xval, int yval)
        {
            this.x = xval;
            this.y = yval;
        }

        public int X { get { return x; } set { x = value; } }

        public int Y { get { return y; } set { y = value; } }
    }
        class Obstacle: Tile
        {
            public Obstacle(int xpos,int ypos)
                :base(xpos,ypos)
            {

            }

        }

        class EmptyTile: Tile
        {
            public EmptyTile(int x,int y)
                : base(x, y)
            {

            }
        }
    
}
