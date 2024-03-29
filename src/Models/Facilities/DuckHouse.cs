using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IResource>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _ducks = new List<IResource>();

        public string ShortId
        {
            get
            {
                return $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            }
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public double Availability
        {
            get
            {
                return _capacity - _ducks.Count;
            }
        }

        public double AnimalCount
        {
            get
            {
                return _ducks.Count;
            }
        }

        public void AddResource(IResource duck)
        {
            // TODO: implement this...
            _ducks.Add(duck);
        }

        public void AddResource(List<IResource> ducks)
        {
            // TODO: implement this...
            _ducks.AddRange(ducks);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._ducks.Count} ducks\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}