using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Map
    {
        private char[,] tile;
        //Hero hero = new Hero();
        private Enemy[] enemies;
        private int width, height;
        private Random randomize = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight,int numEnemies)
        {
            this.width = randomize.Next(minWidth, maxWidth + 1);
            this.height = randomize.Next(minHeight, maxHeight + 1);
            this.tile = new char[height,width];
            this.enemies = new Enemy[numEnemies];
            Create();//hero

            for (int i = 0; i < enemies.Length; i++)
            {
                Create();//enemy
            }

            UpdateVision();
        }

        public void Create()
        {

        }

        public void UpdateVision()
        {

        }

       /* private Tile Create(Tile.TileType type)
        {
            return;
        }*/


    }
}
