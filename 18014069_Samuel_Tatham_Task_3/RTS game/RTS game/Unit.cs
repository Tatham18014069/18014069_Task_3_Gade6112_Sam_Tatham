using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    abstract class Unit
    {
        #region Variables
        protected int x;
        protected int y;
        protected int health;
        protected bool attack;
        protected int range;
        protected int speed;
        protected string faction;
        protected string symbol;
        protected string name;
        #endregion

        #region Constructors
        public Unit(int x, int y, int health, bool attack, int range, int speed, string faction, string symbol, string name)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.attack = attack;
            this.range = range;
            this.speed = speed;
            this.faction = faction;
            this.symbol = symbol;
            this.name = name;
        }
        #endregion

        #region Accessors
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
        public bool Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Methods
        abstract public void PositionMove();
        abstract public void Combat();
        abstract public bool RangeCheck();
        abstract public void ClosestUnit();
        abstract public bool IsAlive();
        abstract public void DisplayInfo();
        abstract public void Save();
        abstract public string toString();
        #endregion
    }
}
