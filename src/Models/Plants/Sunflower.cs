using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, IPlowed, INatural
    {
        private int _seedsProduced = 65;
        public string Type { get; } = "Sunflower";
        public double SeedsPerRow { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChooseNatural()
        {
            throw new NotImplementedException();
        }

        public void ChoosePlowed()
        {
            throw new NotImplementedException();
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}