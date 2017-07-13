using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for dictionary
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>();
            //{
            //    { "A1", "Twix" },
            //    { "A2", "Gummie Bears" },
            //    { "A3","Reeses"},

            //    };


            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");


            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int,string> drink in drinkMachine)

            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }
            {
                Dictionary<int, string> coatCheck = new Dictionary<int, string>();
                {
                    coatCheck.Add(10, "black coat");
                    coatCheck.Add(11, "green coat");
                    coatCheck.Add(12, "blue coat");
                    coatCheck.Add(13, "red coat");
                    coatCheck.Add(14, "pink coat");
                    coatCheck.Add(15, "yelow coat");
                    coatCheck.Add(16, "violet coat");
                    coatCheck.Add(17, "peach coat");
                    coatCheck.Add(18, "indigo coat");
                    coatCheck.Add(19, "fur coat");
                }
                Console.WriteLine(coatCheck.Count);

                foreach (KeyValuePair<int, string> coat in coatCheck)
                {
                    Console.WriteLine(coat.Key);
                    Console.WriteLine(coat.Value);

               }

                Dictionary<string, string> carValet = new Dictionary<string, string>();
                {
                    carValet.Add("Willis", "Toyota");
                    carValet.Add("Simpson", "Honda");
                    carValet.Add("Carr", "VW");
                    carValet.Add("Jones", "BMW");
                    carValet.Add("SMith", "Lexus");
                    carValet.Add("Green", "Chevy");
                    carValet.Add("Belle", "Mercedes");
                    carValet.Add("Thome", "Volvo");
                    carValet.Add("Ramirez", "LandRover");
                    carValet.Add("Vizquel", "Audi");
                }
                Console.WriteLine(carValet.Count);
                foreach (KeyValuePair<string,string>cars in carValet)
                {
                    Console.WriteLine(cars.Key);
                    Console.WriteLine(cars.Value);
                }




            }








            }
        }
    }

