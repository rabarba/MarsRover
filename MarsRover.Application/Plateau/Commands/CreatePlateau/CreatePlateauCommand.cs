using MarsRover.Domain.Interfaces;
using MediatR;

namespace MarsRover.Application.Plateau.Commands.CreatePlateau
{
    public class CreatePlateauCommand : IRequest<IPlateau>
    {
        public string Size { get; set; }
    }
}
