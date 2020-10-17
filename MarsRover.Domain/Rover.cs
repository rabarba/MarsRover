using MarsRover.Domain.Enums;
using MarsRover.Domain.Interfaces;

namespace MarsRover.Domain
{
    public class Rover : IRover
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public Direction Direction { get; set; }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.N:
                    LocationY += 1;
                    break;
                case Direction.S:
                    LocationY -= 1;
                    break;
                case Direction.E:
                    LocationX += 1;
                    break;
                case Direction.W:
                    LocationX -= 1;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.N;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
                default:
                    break;
            }
        }

        public string GetLocationInformation()
        {
            return $"{LocationX} {LocationY} {Direction}";
        }
    }
}
