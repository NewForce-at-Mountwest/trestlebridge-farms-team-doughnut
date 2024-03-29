using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing, IPlowed
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";
        public double SeedsPerRow { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChoosePlowed()
        {
            throw new NotImplementedException();
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}