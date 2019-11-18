using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public string ShortId
        {
            get
            {
                return $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}" ;
            }
        }

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public double Availability {
            get {
                return _capacity - _animals.Count;
            }
        }

        public double AnimalCount {
            get {
                return _animals.Count;
            }
        }

        public void AddResource (IGrazing animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
        }

        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append($"Grazing field {ShortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}