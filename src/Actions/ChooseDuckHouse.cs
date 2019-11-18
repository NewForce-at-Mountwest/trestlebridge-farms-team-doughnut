using System;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IResource duck)
        {
            Utils.Clear();

            Console.WriteLine("List of duck houses: ");

            List<DuckHouse> AvailableDuckHouses = farm.DuckHouses.Where(house => house.Availability > 0).ToList();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House({AvailableDuckHouses[i].ShortId}), currently contains {AvailableDuckHouses[i].AnimalCount} ducks.");
            }

            Console.WriteLine();

            // How can I output the type of chicken chosen here?
            Console.WriteLine($"Place the duck where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.DuckHouses[choice - 1].AddResource(duck);
        }
    }
}