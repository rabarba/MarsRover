using MarsRover.Application;
using MarsRover.Application.Plateau.Commands.CreatePlateau;
using MarsRover.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MarsRover.Test
{
    public class PlateauCommandHandlerTest
    {
        private readonly IMediator mediator;

        public PlateauCommandHandlerTest()
        {
            var services = IoCBuilder.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            mediator = serviceProvider.GetService<IMediator>();
        }

        [Theory]
        [InlineData("5 5")]
        public void Should_Create_Plateau(string plateauSize)
        {
            // Act
            var plateau = mediator.Send(new CreatePlateauCommand { Size = plateauSize }).Result;

            // Assert
            Assert.Equal(5, plateau.SizeX);
        }
    }
}
