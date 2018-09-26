using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RTS_game
{
    class ResourceBuilding : Building
    {
        private string type;
        private int generate;
        private int amount;

        public ResourceBuilding(int x, int y, int health, string faction, string symbol)
            : base(x, y, health, faction, symbol)
        {

        }

        public void resource()
        {

        }

        override public void IsDead()
        {

        }

        override public void Save()
        {
            FileStream outFile = new FileStream("Files\\ResourceSave.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(x);
            writer.WriteLine(y);
            writer.WriteLine(health);
            writer.WriteLine(faction);
            writer.WriteLine(symbol);
            writer.WriteLine(type);
            writer.WriteLine(generate);
            writer.WriteLine(amount);

            writer.Close();
            outFile.Close();
        }

        override public string toString()
        {
            return toString();
        }
    }
}
