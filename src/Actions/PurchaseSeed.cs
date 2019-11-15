using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Actions;

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
                    Console.WriteLine("purchasing Sunflower Seed, press enter to continue");
                    Console.ReadLine();
                    Farm.PurchaseResource<Sunflower>();
                    break;
                case 2:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;
                case 3:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                default:
                    break;
            }
        }
    }
}