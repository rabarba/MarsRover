using MarsRover.Domain.Interfaces;
using System.Collections.Generic;

namespace MarsRover.Domain
{
    public class Plateau : IPlateau
    {
        public Plateau()
        {
            Rovers = new List<IRover>();
        }

        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public List<IRover> Rovers { get; set; }

        public void AddRover(IRover rover)
        {
            Rovers.Add(rover);
        }
    }
}
