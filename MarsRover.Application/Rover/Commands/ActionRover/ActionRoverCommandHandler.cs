using MarsRover.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarsRover.Application.Rover.Commands.ActionRover
{
    public class ActionRoverCommandHandler : IRequestHandler<ActionRoverCommand, IRover>
    {
        public async Task<IRover> Handle(ActionRoverCommand request, CancellationToken cancellationToken)
        {
            var movements = request.Movements.ToCharArray();

            foreach (var movement in movements)
            {
                switch (movement)
                {
                    case 'L':
                        request.Rover.TurnLeft();
                        break;
                    case 'R':
                        request.Rover.TurnRight();
                        break;
                    case 'M':
                        request.Rover.Move();
                        break;
                    default:
                        break;
                }
            }

            return request.Rover;
        }
    }
}
