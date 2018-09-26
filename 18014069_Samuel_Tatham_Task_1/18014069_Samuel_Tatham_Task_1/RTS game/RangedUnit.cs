using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    class RangedUnit : Unit
    {
        public RangedUnit(string name, string type, int health, int attack, int range, int speed, string faction, string symbol, int positionX, int positionY)
        : base(name, type, health, attack, range, speed, faction, symbol, positionX, positionY)
        {

        }

        override public void PositionMove()
        {

        }


        override public void Combat()
        {

        }

        override public bool RangeCheck()
        {
            return true;
        }


        override public void ClosestUnit()
        {

        }


        override public void Death()
        {

        }


        override public void DisplayInfo()
        {

        }


        override public string toString()
        {
            return toString();
        }
    }


}
