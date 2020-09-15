using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Character: Tile
    {
        protected int HP;
        protected int MAxHP;
        protected int Damage;
        protected char[,] Vision;

        public enum Movement { Nothing = 0, left = 1, right = 2, up = 3, down = 4 }

        public Character(int x,int y,char symbol)
            :base(x,y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Attack(char target)
        {
            HP -= this.HP;
        }

        public bool IsDead()
        {
            bool dead = false;
            if (HP >= 0)
            {
                dead = true;
            }

            return dead;
        }

        public virtual bool CheckRange(string Chartarget)
        {
            bool valid = false;
            int range = DistanceTo(Chartarget);

            if (range == 1)
            {
                valid = true;
            }

            return valid;
        }

        private int DistanceTo( string target)
        {
            int distance = 0;

            //calculations==========

            return distance;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Nothing:
                    break;
                case Movement.left:
                    this.x -= 1;
                    break;
                case Movement.right:
                    this.x += 1;
                    break;
                case Movement.up:
                    this.y -= 1;
                    break;
                case Movement.down:
                    this.y += 1;
                    break;
            }
        }

        public virtual Movement ReturnMove(Movement move = 0)
        {
            return move;
        }

        public abstract override string ToString();
    }
}
