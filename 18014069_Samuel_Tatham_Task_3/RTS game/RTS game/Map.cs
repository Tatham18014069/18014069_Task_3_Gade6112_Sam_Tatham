using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RTS_game
{
    class Map
    {
        MeleeUnit mu = new MeleeUnit();
        RangedUnit ru = new RangedUnit();
        FactoryBuilding fb = new FactoryBuilding();
        ResourceBuilding rb = new ResourceBuilding();
        private string[,] grid = new string[20, 20];
        private List<Unit> UnitList = new List<Unit>();
        private List<Building> BuildingList = new List<Building>();
        int maxUnits = 40;
        int numberOfUnits = 0;
        int maxBuildings = 4;
        int numberOfBuildings = 0;
        int x = 0;
        int y = 0;
        Random rnd = new Random();

        public void InitialiseMap()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    grid[i, j] += ".";
                }
            }
        }

        public void PlaceUnits(int x, int y, int health, bool attack, int range, int speed, string faction, string symbol, string name)
        {
            while (numberOfUnits < maxUnits)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                if (grid[x, y] == ".")
                {
                    int tn = rnd.Next(0, 2);
                    int fn = rnd.Next(0, 2);
                    int rn = rnd.Next(0, 2);
                    int mn = rnd.Next(0, 4);
                    string[] nr = new string[] { "Archer", "Scout" };
                    string[] nm = new string[] { "Fighter", "Barbarian", "Rogue", "Man at arms" };

                    if ((tn) % 2 == 0)
                    {
                        health = ru.Health;
                        attack = ru.Attack;
                        range = ru.Range;
                        speed = ru.Speed;
                        symbol = ru.Symbol;
                        name = Convert.ToString(nr[rn]);

                        if ((fn) % 2 == 0)
                            faction = "Sunlanders";

                        else
                            faction = "Nightlaws";


                        UnitList.Add(ru);
                        grid[x, y] = ru.Symbol;
                        numberOfUnits++;
                    }
                    else
                    {
                        health = mu.Health;
                        attack = mu.Attack;
                        range = mu.Range;
                        speed = mu.Speed;
                        symbol = mu.Symbol;
                        name = Convert.ToString(nm[mn]);

                        if ((fn) % 2 == 0)
                            faction = "Sunlanders";

                        else
                            faction = "Nightlaws";

                        UnitList.Add(mu);
                        grid[x, y] = mu.Symbol;
                        numberOfUnits++;
                    }
                }
            }
            while (numberOfBuildings < maxBuildings)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                if (grid[x, y] == ".")
                {
                    int tn = rnd.Next(0, 2);
                    int fn = rnd.Next(0, 2);

                    if ((tn) % 2 == 0)
                    {
                        health = fb.Health;
                        symbol = fb.Symbol;

                        if ((fn) % 2 == 0)
                            faction = "Sunlanders";

                        else
                            faction = "Nightlaws";

                        BuildingList.Add(fb);
                        grid[x, y] = fb.Symbol;
                        numberOfBuildings++;
                    }
                    else
                    {
                        health = rb.Health;
                        symbol = rb.Symbol;

                        if ((fn) % 2 == 0)
                            faction = "Sunlanders";

                        else
                            faction = "Nightlaws";
                    }
                    BuildingList.Add(rb);
                    grid[x, y] = rb.Symbol;
                    numberOfBuildings++;
                }
            }
        }

        public void MoveUnit(int positionX, int positionY, int newPositionX, int newPositionY)
        {
            string temp = "";
            temp = grid[positionX, positionY];
            grid[positionX, positionY] = ".";
            grid[newPositionX, newPositionY] = temp;
        }

        public string RedrawMap()
        {
            string redraw = "";
            for (int k = 0; k < 20; k++)
            {
                for (int l = 0; l < 20; l++)
                {
                    redraw += grid[k, l];
                }
                if (k != 19)
                    redraw += Environment.NewLine;
            }
            return redraw;
        }

        private void UnitUpdate()
        {

        }

        #region Save
        public void Save(List<Unit> uList, List<Building> bList)
        {
            foreach (Unit u in uList)
            {
                u.Save();
            }

            foreach (Building b in bList)
            {
                b.Save();
            }

            FileStream outFile = new FileStream("Files\\Map.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            for (int m = 0; m < 20; m++)
            {
                for (int n = 0; n < m; n++)
                {
                    writer.WriteLine(Convert.ToString(grid[m, n]));
                }
            }

            writer.Close();
            outFile.Close();
        }
        #endregion

        #region Load
        public void ReadFactoryBuilding()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int x;
            int y;
            int health;
            string faction;
            string symbol;
            inFile = new FileStream("Files\\FactoryBuilding.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = int.Parse(input);
                y = int.Parse(reader.ReadLine());
                health = int.Parse(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                Building fb = new FactoryBuilding(x, y, health, faction, symbol);
                BuildingList.Add(fb);
                input = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }

        public void ReadResourceBuilding()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int x;
            int y;
            int health;
            string faction;
            string symbol;
            inFile = new FileStream("Files\\ResourceBuilding.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = int.Parse(input);
                y = int.Parse(reader.ReadLine());
                health = int.Parse(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                Building rb = new ResourceBuilding(x, y, health, faction, symbol);
                BuildingList.Add(rb);
                input = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }

        public void ReadRangedUnit()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int x;
            int y;
            int health;
            bool attack;
            int range;
            int speed;
            string faction;
            string symbol;
            string name;
            inFile = new FileStream("Files\\RangedUnit.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = int.Parse(input);
                y = int.Parse(reader.ReadLine());
                health = int.Parse(reader.ReadLine());
                attack = Convert.ToBoolean(reader.ReadLine());
                range = int.Parse(reader.ReadLine());
                speed = int.Parse(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                name = reader.ReadLine();
                Unit ru = new RangedUnit(x, y, health, attack, range, speed, faction, symbol, name);
                UnitList.Add(ru);
                grid[x, y] = ru.Symbol;

                input = reader.ReadLine();
            }


            reader.Close();
            inFile.Close();
        }
        public void ReadMeleeUnit()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int x;
            int y;
            int health;
            bool attack;
            int range;
            int speed;
            string faction;
            string symbol;
            string name;

            inFile = new FileStream("Files\\MeleeUnit.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = int.Parse(input);
                y = int.Parse(reader.ReadLine());
                health = int.Parse(reader.ReadLine());
                attack = Convert.ToBoolean(reader.ReadLine());
                range = int.Parse(reader.ReadLine());
                speed = int.Parse(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                name = reader.ReadLine();
                Unit mu = new MeleeUnit(x, y, health, attack, range, speed, faction, symbol, name);
                UnitList.Add(mu);
                grid[x, y] = mu.Symbol;

                input = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }

        public void ReadMap()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            string output = "";

            inFile = new FileStream("Files\\Map.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
                output += input;
                grid[x, y] = mu.Symbol;
                for (int m = 0; m < 20; m++)
                {
                    for (int n = 0; n < m; n++)
                    {
                        grid[m, n] += reader.ReadLine();
                    }
                }

            reader.Close();
            inFile.Close();
        }
        #endregion
    }
}
