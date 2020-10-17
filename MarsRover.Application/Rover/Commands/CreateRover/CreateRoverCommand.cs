using MarsRover.Domain.Interfaces;
using MediatR;

namespace MarsRover.Application.Rover.Commands.CreateRover
{
    public class CreateRoverCommand : IRequest<IRover>
    {
        public string Location { get; set; }
        public IPlateau Plateau { get; set; }
    }
}
