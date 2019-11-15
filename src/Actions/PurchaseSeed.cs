using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeed {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sunflower");
            Console.WriteLine ("2. Wilflower");
            Console.WriteLine ("3. Sesame");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseSunflowerSeed.CollectInput(farm, new Sunflower());
                    break;
                case 2:
                    ChooseWildflowerSeed.CollectInput(farm, new Wildflower());
                    break;
                case 1:
                    ChooseSesameSeed.CollectInput(farm, new Sesame());
                    break;
                default:
                    break;
            }
        }
    }
}