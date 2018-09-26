using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RTS_game
{
    class FactoryBuilding : Building
    {
        private string units;
        private int generate;
        private int placement;

        public FactoryBuilding(int x, int y, int health, string faction, string symbol)
            : base(x, y, health, faction, symbol)
        {
            health = 500;
            symbol = "F";
        }

        public FactoryBuilding()
        {
        }

        public void spawn()
        {

        }

        override public void Generate(string faction, string symbol, string name)
        {

        }

        override public bool IsAlive()
        {
            return true;
        }

        override public void Save()
        {
            FileStream outFile = new FileStream("Files\\FactorySave.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(x);
            writer.WriteLine(y);
            writer.WriteLine(health);
            writer.WriteLine(faction);
            writer.WriteLine(symbol);
            writer.WriteLine(units);
            writer.WriteLine(generate);
            writer.WriteLine(placement);

            writer.Close();
            outFile.Close();
        }

        override public string toString()
        {
            return toString();
        }
    }
}
