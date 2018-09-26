using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RTS_game
{
    class MeleeUnit : Unit
    {
        public MeleeUnit(int x, int y, int health, bool attack, int range, int speed, string faction, string symbol, string name, string type)
            :base(x, y, health, attack, range, speed,  faction,  symbol, name, type)
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

        override public void IsAlive()
        {

        }


        override public void DisplayInfo()
        {
            
        }

        override public void Save()
        {
            FileStream outFile = new FileStream(@"Files\MeleeSave.txt", FileMode.Append, FileAccess.Write);
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
            writer.WriteLine(type);

            writer.Close();
            outFile.Close();
        }

        override public string toString()
        {
            return toString();
        }
    }
}
