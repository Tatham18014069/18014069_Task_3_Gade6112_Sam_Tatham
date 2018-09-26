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
        private string[,] grid = new string[20, 20];
        /* RangedUnit[] rHero = new RangedUnit[400];
        MeleeUnit[] mHero = new MeleeUnit[400];
        FactoryBuilding[] fBase = new FactoryBuilding[400];
        ResourceBuilding[] rBase = new ResourceBuilding[400];*/
        private List<Unit> UnitList = new List<Unit>();
        private List<Building> BuildingList = new List<Building>();
        string[] familyName = new string[] { "Iven", "Deven", "Arnold", "Borris", "Silvester", "Ansgar", "Linwood", "Theo", "Dieter", "Witt", "Beardsley", "Reiner", "Bodin", "Alphonse", "Tobias", "Kirk", "Oswald", "Kingsley", "Hendrick", "Alden", "Natalia", "Luna", "Josefin", "Halfieda", "Veronique", "Amaya", "Althee", "Rica", "Amy", "Robina", "Angie", "Jazzmine", "Rayna", "Emilee", "Charlotta", "Lidia", "Rosa", "Meryl", "Heidy", "Aja" };
        int maxUnits = 40;
        int numberOfUnits = 0;
        int maxBuildings = 4;
        int numberOfBuildings = 0;
        int positionX = 0;
        int positionY = 0;
        Random rnd = new Random();

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
                y = reader.ReadLine();
                health = Convert.ToInt32(reader.ReadLine());
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
            string y;
            int health;
            string faction;
            string symbol;
            inFile = new FileStream("Files\\ResourceBuilding.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = int.Parse(input);
                y = reader.ReadLine();
                health = Convert.ToInt32(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                Building fb = new FactoryBuilding(x, y, health, faction, symbol);
                BuildingList.Add(fb);
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
            string name;
            string type;
            int attack;
            int range;
            int speed;
            string faction;
            string symbol;
            int positionX;
            int positionY;

            inFile = new FileStream("Files\\RangedUnit.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();

            

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
            string type;

            inFile = new FileStream("Files\\MeleeUnit.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);
            input = reader.ReadLine();
            while (input != null)
            {
                x = Convert.ToInt32(input);
                y = Convert.ToInt32(reader.ReadLine());
                health = Convert.ToInt32(reader.ReadLine());
                attack = bool.Parse(reader.ReadLine());
                range = Convert.ToInt32(reader.ReadLine());
                speed = Convert.ToInt32(reader.ReadLine());
                faction = reader.ReadLine();
                symbol = reader.ReadLine();
                name = reader.ReadLine();
                type = reader.ReadLine();
                Unit mU = new MeleeUnit(x, y, health, attack, range, speed, faction, symbol, name, type);
                BuildingList.Add(fb);
                grid[x, y] = fb.symbol;

                input = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();            
        }

        public void Save()
        {
            foreach (MeleeUnit u in mHero)
            {
                u.Save();
            }
        }

        public void initialiseMap()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] += ".";
                }
            }
        }

        public void PlaceUnits()
        {
            while (numberOfUnits < maxUnits)
            {
                positionY = rnd.Next(0, 20);
                positionX = rnd.Next(0, 20);
                if (map[positionX, positionY] == ".")
                {
                    int roleSelection = rnd.Next(0, 100);
                    int teamSelection = rnd.Next(0, 100);
                    int nameSelection = rnd.Next(0, 40);

                    if ((roleSelection) % 2 == 0)
                    {
                        if ((teamSelection) % 2 == 0 )
                        {
                            mHero[numberOfUnits] = new MeleeUnit(SelectName[nameSelection], "Warrior", 100, 3, 2, 1, "Sunlander", "@", positionX, positionY);
                            map[positionX, positionY] = mHero[numberOfUnits].Symbol;
                            numberOfUnits++;
                        }
                        else
                        {
                            mHero[numberOfUnits] = new MeleeUnit(SelectName[nameSelection], "Warrior", 100, 3, 2, 1, "Nightlaw", "@", positionX, positionY);
                            map[positionX, positionY] = mHero[numberOfUnits].Symbol;
                            numberOfUnits++;
                        }
                    }
                    else
                    {
                        if ((teamSelection) % 2 == 0)
                        {
                            rHero[numberOfUnits] = new RangedUnit(SelectName[nameSelection], "Ranger", 70, 1, 7, 1, "Sunlander", "#", positionX, positionY);
                            map[positionX, positionY] = rHero[numberOfUnits].Symbol;
                            numberOfUnits++;
                        }
                        else
                        {
                            rHero[numberOfUnits] = new RangedUnit(SelectName[nameSelection], "Ranger", 70, 1, 7, 1, "Nightlaw", "#", positionX, positionY);
                            map[positionX, positionY] = rHero[numberOfUnits].Symbol;
                            numberOfUnits++;
                        }
                    }
                }
            }
            while (numberOfBuildings < maxBuildings)
            {
                positionY = rnd.Next(0, 20);
                positionX = rnd.Next(0, 20);
                if (map[positionX, positionY] == ".")
                {
                    if (numberOfBuildings == 0)
                    {
                        fBase[numberOfBuildings] = new FactoryBuilding(positionX, positionY, 100, "Nightlaw", "F");
                        map[positionX, positionY] = "F";;
                    }

                    if (numberOfBuildings == 1)
                    {
                        fBase[numberOfBuildings] = new FactoryBuilding(positionX, positionY, 100, "SunLander", "F");
                        map[positionX, positionY] = "F";
                    }

                    if (numberOfBuildings == 2)
                    {
                        rBase[numberOfBuildings] = new ResourceBuilding(positionX, positionY, 100, "Nightlaw", "R");
                        map[positionX, positionY] = "R";
                    }

                    if (numberOfBuildings == 3)
                    {
                        rBase[numberOfBuildings] = new ResourceBuilding(positionX, positionY, 100, "Sunlander", "R");
                        map[positionX, positionY] = "R";
                    }

                }
                numberOfBuildings++;
            }
        }

        public void MoveUnit(int positionX, int positionY, int newPositionX, int newPositionY)
        {
            string temp = "";
            temp = map[positionX, positionY];
            map[positionX, positionY] = ".";
            map[newPositionX, newPositionY] = temp;
        }

        public string RedrawMap()
        {
            string redraw = "";
            for (int k = 0; k < 20; k++)
            {
                for (int l = 0; l < 20; l++)
                {
                    redraw += map[k, l];
                }
                if (k != 19)
                    redraw += Environment.NewLine;
            }
            return redraw;
        }
    

        private void UnitUpdate()
        {

        }
    }
}
