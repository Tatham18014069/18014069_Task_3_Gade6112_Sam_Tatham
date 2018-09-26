using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    abstract class Unit
    {
        
        private string name;
        private string role;
        private int health;
        private int attack;
        private int range;
        private int speed;
        private string faction;
        private string symbol;
        private int positionX;
        private int positionY;
        Random rnd = new Random();
        //private String[] Hero = new String[14];


        #region Constructors
        /*public Unit()
        {
            name = "";
            role = "";
            health = 0;
            attack = 0;
            range = 0;
            speed = 0;
            faction = "";
            symbol = "";
            positionX = 0;
            positionY = 0;
        }
        */
        public Unit(string name, string role, int health, int attack, int range, int speed, string faction, string symbol, int positionX, int positionY)
        {
            this.name = name;
            this.role = role;
            this.health = health;
            this.attack = attack;
            this.range = range;
            this.speed = speed;
            this.faction = faction;
            this.symbol = symbol;
            this.positionX = positionX;
            this.positionY = positionY;
        }
        #endregion

        #region Accessors
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Attack
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

        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }
        #endregion

        abstract public void PositionMove();


        abstract public void Combat();

        abstract public bool RangeCheck();


        abstract public void ClosestUnit();


        abstract public void Death();


        abstract public void DisplayInfo();


        abstract public string toString();
    }
}
