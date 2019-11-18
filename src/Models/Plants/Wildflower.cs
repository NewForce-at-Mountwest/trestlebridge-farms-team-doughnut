using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ISeedProducing, INatural
    {
        private int _seedsProduced = 100;
        public string Type { get; } = "Wildflower";

        public void ChooseNatural()
        {
            throw new NotImplementedException();
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Wildflower. Yum!";
        }
    }
}