using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Chicken house");
            Console.WriteLine ("4. Natural Field");
            Console.WriteLine ("5. Duck House");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine("generating grazing field, please press enter to continue");
                    Console.ReadLine();
                    farm.AddGrazingField(new GrazingField());
                    break;

                case 2:
                    Console.WriteLine("Generating plowed field, please press enter to continue");
                    Console.ReadLine();
                    farm.AddPlowedField(new PlowedField());
                    break;


                case 5:
                    Console.WriteLine ("generating duck house, please press enter to continue");
                    Console.ReadLine ();


                    farm.AddDuckHouse(new DuckHouse());
                    break;
                case 3:
                    Console.WriteLine("Creating chicken house, please press enter to continue");
                    Console.ReadLine();
                    farm.AddChickenHouse(new ChickenHouse());
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