using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    abstract class Building
    {
        #region Variables
        protected int x;
        protected int y;
        protected int health;
        protected string faction;
        protected string symbol;
        #endregion

        #region Constructors
        public Building(int x, int y, int health, string faction, string symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.faction = faction;
            this.symbol = symbol;
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
        #endregion

        #region Methods
        abstract public bool IsAlive();
        abstract public void Save();
        abstract public string toString();
        #endregion
    }
}
