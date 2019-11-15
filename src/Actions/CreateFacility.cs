using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");

            Console.WriteLine ("4. Natural Field");
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

                    case 4:
                    Console.WriteLine ("generating natural field, please press enter to continue");
                    Console.ReadLine ();


                    farm.AddNaturalField(new NaturalField());
                    break;


                default:
                    break;
            }

        }
    }
}