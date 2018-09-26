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
        public RangedUnit(int x, int y, int health, bool attack, int range, int speed, string faction, string symbol, string name)
        : base(x, y, health, attack, range, speed, faction, symbol, name)
        {
            x = 0;
            y = 0;
            health = 50;
            attack = false;
            range = 6;
            speed = 1;
            symbol = "#";
            faction = "";
            name = "";
        }

        public RangedUnit()
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


        override public bool IsAlive()
        {
            return true;
        }


        override public void DisplayInfo()
        {

        }

        override public void Save()
        {
            FileStream outFile = new FileStream("Files\\RangedSave.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(x);
            writer.WriteLine(y);
            writer.WriteLine(health);
            writer.WriteLine(attack);
            writer.WriteLine(range);
            writer.WriteLine(speed);
            writer.WriteLine(faction);
            writer.WriteLine(symbol);
            writer.WriteLine(name);

            writer.Close();
            outFile.Close();
        }


        override public string toString()
        {
            return toString();
        }

    }
}
