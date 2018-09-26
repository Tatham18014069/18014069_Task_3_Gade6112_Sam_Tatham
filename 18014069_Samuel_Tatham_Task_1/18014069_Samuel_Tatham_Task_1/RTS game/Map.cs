using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    class Map
    {
        private string[,] map = new string[20, 20];
        RangedUnit[] rHero = new RangedUnit[400];
        MeleeUnit[] mHero = new MeleeUnit[400];
        string[] SelectName = new string[] { "Iven", "Deven", "Arnold", "Borris", "Silvester", "Ansgar", "Linwood", "Theo", "Dieter", "Witt", "Beardsley", "Reiner", "Bodin", "Alphonse", "Tobias", "Kirk", "Oswald", "Kingsley", "Hendrick", "Alden", "Natalia", "Luna", "Josefin", "Halfieda", "Veronique", "Amaya", "Althee", "Rica", "Amy", "Robina", "Angie", "Jazzmine", "Rayna", "Emilee", "Charlotta", "Lidia", "Rosa", "Meryl", "Heidy", "Aja" };
        Double xSqr, ySqr, distance, closest = 20;
        int maxUnits = 40;
        int numberOfUnits = 0;
        int positionX = 0;
        int positionY = 0;
        Random rnd = new Random();

        public void initiliseMap()
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
                            map[positionX, positionY] = "@";
                            numberOfUnits++;
                        }
                        else
                        {
                            mHero[numberOfUnits] = new MeleeUnit(SelectName[nameSelection], "Warrior", 100, 3, 2, 1, "Nightlaw", "#", positionX, positionY);
                            map[positionX, positionY] = "@";
                            numberOfUnits++;
                        }
                    }
                    else
                    {
                        if ((teamSelection) % 2 == 0)
                        {
                            rHero[numberOfUnits] = new RangedUnit(SelectName[nameSelection], "Ranger", 70, 1, 7, 1, "Sunlander", "@", positionX, positionY);
                            map[positionX, positionY] = "#";
                            numberOfUnits++;
                        }
                        else
                        {
                            rHero[numberOfUnits] = new RangedUnit(SelectName[nameSelection], "Ranger", 70, 1, 7, 1, "Nightlaw", "#", positionX, positionY);
                            map[positionX, positionY] = "#";
                            numberOfUnits++;
                        }
                    }
                }
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
            for (int k = 0; k < 19; k++)
            {
                for (int l = 0; l < 20; l++)
                {
                    redraw += map[k, l];
                    if (map[k, l] == ".")
                        redraw += "   ";
                    if (map[k, l] == "#")
                        redraw += "  ";
                }
                redraw += Environment.NewLine;
            }
            for (int p = 0; p < 20; p++)
                redraw += "#  ";
            return redraw;
        }
    

        private void UnitUpdate()
        {

        }
    }
}
