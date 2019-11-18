using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IResource chicken)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House ");
            }

            Console.WriteLine();

            // How can I output the type of chicken chosen here?
            Console.WriteLine($"Place the chicken where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.ChickenHouses[choice - 1].AddResource(chicken);
        }
    }
}