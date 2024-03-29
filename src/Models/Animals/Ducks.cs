using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource

    {

        private Guid _id = Guid.NewGuid();
        private double _eggsProduced = 6;
        private double _feathersProduced = 0.75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double GetEggs()
        {
            return _eggsProduced;
        }
        public double Pluck()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. QUACK!";
        }
    }
}