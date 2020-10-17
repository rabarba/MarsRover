using MarsRover.Domain.Enums;
using MarsRover.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarsRover.Application.Rover.Commands.CreateRover
{
    public class CreateRoverCommandHandler : IRequestHandler<CreateRoverCommand, IRover>
    {
        private readonly IRover _rover;

        public CreateRoverCommandHandler(IRover rover)
        {
            _rover = rover;
        }

        public async Task<IRover> Handle(CreateRoverCommand request, CancellationToken cancellationToken)
        {
            var locations = request.Location.Split(' ');
            var locationX = int.Parse(locations[0]);
            var locationY = int.Parse(locations[1]);
            var direction = (Direction)Enum.Parse(typeof(Direction), locations[2]);

            _rover.LocationX = locationX;
            _rover.LocationY = locationY;
            _rover.Direction = direction;
            request.Plateau.AddRover(_rover);

            return _rover;
        }
    }
}
