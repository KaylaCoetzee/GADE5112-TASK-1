using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeAssignment
{
    class RangedUnit: Unit
    {
        public RangedUnit() { }

        private const int DAMAGE = 1;

        //constructors

        public RangedUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol)
            : base(x, y, health, speed, attack, attackRange, faction, symbol)
        {
        }

        public override void position(int xPosition, int yPosition)
        {
            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < 1; i++)
            {
                x = rnd.Next(1, 6);
                y = rnd.Next(1, 6);

                xPosition = x;
                yPosition = y;
            }

        }
        public override void combat()
        {
            int hp;
            Random rnd = new Random();
            hp = rnd.Next(0, 101);

            if (hp >= 1 && hp >= 100)
            {
                health = health - hp;
            }
        }
        public override void range(int a)
        {

        }
        public override void closestUnit(int a)
        {

        }
        public override bool death(int a)
        {
            if (health <= 0)
            {
                return true;
            }
            else
                return false;
        }
        public override string toString()
        {
            string output;
            output = "";
            return output;
        }

        
    }
}
