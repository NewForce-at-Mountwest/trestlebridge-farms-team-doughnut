using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _plants = new List<INatural>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (INatural plants)
        {

           _plants.Add(plants);
        }

        public void AddResource(List<INatural> resources)
        {
            throw new NotImplementedException();
        }

        // public void AddResource(List<INatural> plants) =>
        //    // TODO: implement this...
        //    _plants.Add(List < INatural > plants)


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}