using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvOPolisVersion2.Person;

namespace TjuvOPolisVersion2
{
    internal class City
    {
        public static string[,] city = new string[25, 100];

        public static List<Robber> robbers = new List<Robber>();
        public static List<Citizen> citizens = new List<Citizen>();
        public static List<Police> polices = new List<Police>();

        public void Start()
        {
            MakeListOfPersons();

            while (true)
            {
                foreach (Citizen citizen in citizens)
                {
                    city[citizen.LocationRow, citizen.LocationCol] = citizen.Name;
                    citizen.Movement();
                }

                foreach (Robber robber in robbers)
                {
                    if (city[robber.LocationRow, robber.LocationCol] == "C")
                    {
                        //Metod för att stjäla items
                        Console.WriteLine("Tjuv rånar medborgare");
                        
                    }
                    else
                    {
                        city[robber.LocationRow, robber.LocationCol] = robber.Name;
                        robber.Movement();
                    }
                }

                foreach (Police police in polices)
                {
                    city[police.LocationRow, police.LocationCol] = police.Name;
                    police.Movement();
                }

                for (int i = 0; i < city.GetLength(0); i++)
                {
                    for (int j = 0; j < city.GetLength(1); j++)
                    {
                        if (city[i, j] != null)
                        {
                            Console.Write(city[i, j]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < city.GetLength(0); i++)
                {
                    for (int j = 0; j < city.GetLength(1); j++)
                    {
                        city[i, j] = null;
                    }
                }
            }

        }



        public static void MakeListOfPersons()
        {
            for (int i = 0; i < 2; i++)
            {
                Police police = new Police();
                polices.Add(police);
            }
            for (int i = 0; i < 2; i++)
            {
                Citizen citizen = new Citizen();
                citizens.Add(citizen);
            }
            for (int i = 0; i < 2; i++)
            {
                Robber robber = new Robber();
                robbers.Add(robber);
            }
        }
    }
}
