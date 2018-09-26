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

        #region Methods
        abstract public void IsAlive();
        abstract public void Save();
        abstract public string toString();
        #endregion
    }
}
