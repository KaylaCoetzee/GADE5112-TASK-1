using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeAssignment
{
    abstract class Unit
    {
        public Unit()
        {

        }
        //variables
        
        protected int x;
        protected int y;
        protected int health;
        protected int speed;
        protected bool attack;
        protected int attackRange;
        protected string faction;
        protected string symbol;

        //accessors
        public int X 

        {
            get { return x; }
            set { x = value; }
        }
        public int Y  

        {
            get { return y; }
            set { y = value; }
        }

        public int Health 

        {
            get { return health; }
            set { health = value; }
        }

        public int Speed

        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Attack 

        {
            get { return attack; }
            set { attack = value; }
        }
        public int AttackRange 

        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public string Faction 

        {
            get { return faction; }
            set { faction = value; }
        }
        public string Symbol

        {
            get { return symbol; }
            set { symbol = value; }
        }

        //constructors


        public Unit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol)
        {

            this.x = x;
            this.y = y;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
        }

        //destructor
        ~Unit()
        {
        }

        public abstract void position(int xPosition, int yPosition);
        public abstract void combat();
        public abstract void range(int a);
        public abstract void closestUnit(int a);
        public abstract bool death(int a);
        public abstract string toString();
        //method

    }
}
