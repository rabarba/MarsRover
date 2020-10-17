using MarsRover.Domain.Interfaces;
using MediatR;

namespace MarsRover.Application.Rover.Commands.ActionRover
{
    public class ActionRoverCommand : IRequest<IRover>
    {
        public string Movements { get; set; }
        public IRover Rover { get; set; }
    }
}
