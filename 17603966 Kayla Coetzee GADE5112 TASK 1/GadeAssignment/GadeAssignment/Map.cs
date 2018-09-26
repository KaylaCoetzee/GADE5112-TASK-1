using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeAssignment
{
    public class Map
    {
        
        private string[,] map = new string[20, 20];
        private MeleeUnit[] mU = new MeleeUnit[50];
        private int numberMeleeUnits = 0;
        private int numberRangeUnits = 0;
        private RangedUnit[] rU = new RangedUnit[50];

        //public string unitFaction;

        //public void team()
        //{
        //    Random rnd = new Random();
        //    int factionChoice = rnd.Next(1, 3);

        //    if (factionChoice == 1)
        //    {
        //        unitFaction = "G";
        //    }
        //    else if (factionChoice == 2)
        //    {
        //        unitFaction = "B";
        //    }

        //}


        public string initialiseMap()
        {
            string showMap = "";


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] = ".";

                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    showMap += map[i, j];
                }
                showMap += "\n";
            }

            return showMap;


        }

        public string redraw()
        {
            
            string display = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    display += map[i, j] + " ";
                }
                display += Environment.NewLine;
            }
            return display;

            
        }
        //placing units in different teams

        private void placeMeleeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "M";

        }
        private void placeRangeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "R";

        }


        public void generateUnits()
        {

            //team();

            Random rnd = new Random();
                numberMeleeUnits = rnd.Next(25, 51);
                int x, y;

            //blue team

                for (int i = 0; i < numberMeleeUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");


                    mU[i] = new MeleeUnit(x, y, 100, -1, true, 1, "B", "M");
                    placeMeleeUnit(x, y);
                }

                //Random rand = new Random();
                numberRangeUnits = rnd.Next(25, 51);
                //int a, b;

                for (int i = 0; i < numberRangeUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                        x = rnd.Next(0, 20);
                        y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");

                    rU[i] = new RangedUnit(x, y, 100, -1, true, 5, "G", "R");
                    placeRangeUnit(x, y);
                }
        }
    
        public void moveUnit()
        {

            
        }


        //public void (MeleeUnit, int x, int y)
        //{
        //    mU.X = x;
        //    meleeUnit.Y = y;
        //}

        //public void update(Map.mU)
        //{
        //    map[uRange.X, uRange.Y] = ".";
        //    position(mU, new X, new Y);
        //    map[mU.X, M.Y] = ".";
        //}
    }

}

