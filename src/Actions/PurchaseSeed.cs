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
            Console.WriteLine ("Choose seed to purchase.");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            if (choice == "1")
            {

                    Console.WriteLine("1. Plowed Field");
                    Console.WriteLine("2. Natural Field");
                    Console.WriteLine();
                    Console.WriteLine("Choose a FIELD option");
                    Console.Write("> ");
                    string option = Console.ReadLine();
                    if (option == "1")
                {
                    // List plowed fields and user inputs the number, which will be used as second parameter.
                    int i;
                    for(i = 0; i < farm.PlowedFields.Count; i++){
                        Console.WriteLine($"{i} Plowed Field");}

                        Console.WriteLine("Choose a Plowed Field");
                        Console.Write("> ");
                        string pickNumber = Console.ReadLine();
                        int result = Int32.Parse(pickNumber);
                        farm.PurchaseResource<Sunflower>(new Sunflower(), result);
                    }
                else if (option == "2")
                {
                    // List Natural Fields and give option of which one user wants to pick.

                    int i;
                    for(i = 1; i < farm.NaturalFields.Count; i++){
                        Console.WriteLine($"{i} Natural Field");}

                        Console.WriteLine("Choose a Natural Field");
                        Console.Write("> ");
                        string pickNumber = Console.ReadLine();
                        int result = Int32.Parse(pickNumber);
                        farm.PurchaseResource<Sunflower>(new Sunflower(), result);
                    }
                }

               else if (choice == "2")

                 {
                    // List Natural Fields and give option of which one user wants to pick.

                    int i;
                    for(i = 1; i < farm.NaturalFields.Count; i++){
                        Console.WriteLine($"{i} Natural Field");}

                        Console.WriteLine("Choose a Natural Field");
                        Console.Write("> ");
                        string pickNumber = Console.ReadLine();
                        int result = Int32.Parse(pickNumber);
                        farm.PurchaseResource<Wildflower>(new Wildflower(), result);
                    }

              else if (choice == "3")

                {

                    int i;
                    for(i = 1; i < farm.PlowedFields.Count; i++){
                        Console.WriteLine($"{i} Plowed Field");}

                        Console.WriteLine("Choose a Plowed Field");
                        Console.Write("> ");
                        string pickNumber = Console.ReadLine();
                        int result = Int32.Parse(pickNumber);
                        farm.PurchaseResource<Sesame>(new Sesame(), result);
                    }

            }
        }
    }
