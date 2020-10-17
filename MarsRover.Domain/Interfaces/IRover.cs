using MarsRover.Domain.Enums;

namespace MarsRover.Domain.Interfaces
{
    public interface IRover
    {
        int LocationX { get; set; }
        int LocationY { get; set; }
        Direction Direction { get; set; }
        void TurnLeft();
        void TurnRight();
        void Move();
        string GetLocationInformation();
    }
}
