using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural field");
            Console.WriteLine ("4. Chicken house");
            Console.WriteLine ("5. Duck house");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine ("generating grazing field, please press enter to continue");
                    Console.ReadLine ();


                    farm.AddGrazingField(new GrazingField());
                    break;
                default:
                    break;
            }

            switch(Int32.Parse(input))
            {
                case 2:
                    farm.AddPlowedField(new PlowedField());
                    break;
                    default:
                    break;
            }

        }
    }
}