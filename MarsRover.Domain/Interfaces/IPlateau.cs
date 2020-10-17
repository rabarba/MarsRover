using System.Collections.Generic;

namespace MarsRover.Domain.Interfaces
{
    public interface IPlateau
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public List<IRover> Rovers { get; set; }
        void AddRover(IRover rover);
    }
}
