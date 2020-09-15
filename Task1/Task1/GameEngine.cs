using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GameEngine
    {
        private Map mapDisplay;

        public Map Map
        {
            get { return mapDisplay; }
        }

        public GameEngine()
        {
           // var MapDimensions = new Map();
        }

        public bool MovePlayer(Character.Movement direction)
        {
            bool move = false;

            return move;
        }

    }
}
