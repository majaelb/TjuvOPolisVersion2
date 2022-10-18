using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TjuvOPolisVersion2
{
    internal class Person
    {
        public string Name { get; set; } //"M" "T" "P"
        public int LocationRow { get; set; } //nuvarande position, ges av direction
        public int LocationCol { get; set; } //nuvarande position, ges av direction
        public int DirectionRow { get; set; }
        public int DirectionCol { get; set; }
        //public List<string> Inventory { get; set; }
        //public int AmountOfPeople { get; set; }

        //public bool Interaction { get; set; }

        //public Person(string name, int locationRow, int locationCol, int directionRow, int directionCol /*List<string> inventory,int amountOfPeople*/ )
        //{
        //    Random rnd = new Random();
        //    Name = name;
        //    LocationRow = rnd.Next(0,25);
        //    LocationCol = rnd.Next(0,100);
        //    DirectionRow = rnd.Next(-1,2);
        //    DirectionCol = rnd.Next(-1,2);
        //    //Inventory = inventory;
        //    //AmountOfPeople = amountOfPeople;

        //    //Interaction = interaction;

        //}
        public Person()
        {
            Random rnd = new Random();
            Name = " ";
            LocationRow = rnd.Next(1,24);
            LocationCol = rnd.Next(1,99);
            DirectionRow = rnd.Next(-1,2);
            DirectionCol = rnd.Next(-1,2);

        }

        public void Movement()
        {
            LocationCol = MovementCheckCol();
            LocationRow = MovementCheckRow();
        }
        public int MovementCheckCol()
        {
            int locationCol = LocationCol += DirectionCol;
            if (locationCol < 0)
            {
                locationCol = 24;
            }
            else if (locationCol > 24)
            {
                locationCol = 0;
            }
            return locationCol;
        }
        public int MovementCheckRow()
        {
            int locationRow = LocationRow += DirectionRow;
            if (locationRow < 0)
            {
                locationRow = 99;
            }
            else if (locationRow > 100)
            {
                locationRow = 0;
            }
            return locationRow;
        }
    }

    internal class Citizen : Person
        {
            public List<string> Belongings { get; set; }
            public bool Thief { get; set; }

            public Citizen() : base()
            {
                Name = "C";
                Thief = false;
                Belongings = new List<string>();
            }        
    }

        internal class Robber : Person
        {
            public List<string> Loot { get; set; }
            public bool Thief { get; set; }

            public Robber() : base()
            {
                Name = "R";
                Thief = false;
                Loot = new List<string>();
            }       
    }
        internal class Police : Person
        {
            public List<string> Loot { get; set; }
            public bool Thief { get; set; }

            public Police() : base()
            {
                Name = "P";
                Thief = false;
                Loot = new List<string>();
            }       
    }
    }

