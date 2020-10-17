using MarsRover.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarsRover.Application.Plateau.Commands.CreatePlateau
{
    public class CreatePlateauCommandHandler : IRequestHandler<CreatePlateauCommand, IPlateau>
    {
        private readonly IPlateau _plateau;

        public CreatePlateauCommandHandler(IPlateau plateau)
        {
            _plateau = plateau;
        }
        public async Task<IPlateau> Handle(CreatePlateauCommand request, CancellationToken cancellationToken)
        {
            var sizes = request.Size.Split(' ');
            var sizeX = int.Parse(sizes[0]);
            var sizeY = int.Parse(sizes[1]);

            _plateau.SizeX = sizeX;
            _plateau.SizeY = sizeY;

            return _plateau;
        }
    }
}
