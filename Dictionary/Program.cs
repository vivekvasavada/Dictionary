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

            }








            }
        }
    }

