using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        override public void Save()
        {
            FileStream outFile = new FileStream("Files\\RangedSave.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(name);
            writer.WriteLine(type);
            writer.WriteLine(health);
            writer.WriteLine(attack);
            writer.WriteLine(range);
            writer.WriteLine(speed);
            writer.WriteLine(faction);
            writer.WriteLine(symbol);
            writer.WriteLine(positionX);
            writer.WriteLine(positionY);

            writer.Close();
            outFile.Close();
        }


        override public string toString()
        {
            return toString();
        }
    }


}
