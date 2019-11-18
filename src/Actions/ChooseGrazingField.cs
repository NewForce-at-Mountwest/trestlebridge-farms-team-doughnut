using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            Console.WriteLine ("List of grazing fields: ");

            List<GrazingField> AvailableGrazing = farm.GrazingFields.Where(field => field.Availability > 0).ToList();

            for (int i = 0; i < AvailableGrazing.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field({AvailableGrazing[i].ShortId}), currently contains {AvailableGrazing[i].AnimalCount} animals.");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine()) - 1;

            AvailableGrazing[choice].AddResource(animal);
            Console.WriteLine(AvailableGrazing[choice]);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}