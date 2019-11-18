using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IResource>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _chickens = new List<IResource>();

        public double chickenCount { get { return _chickens.Count; } }


        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IResource chicken)
        {
            // TODO: implement this...
            _chickens.Add(chicken);
        }

        public void AddResource(List<IResource> chickens)
        {
            // TODO: implement this...
            _chickens.AddRange(chickens);

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}