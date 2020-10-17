using MarsRover.Application;
using MarsRover.Application.Rover.Commands.ActionRover;
using MarsRover.Application.Rover.Commands.CreateRover;
using MarsRover.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MarsRover.Test
{
    public class RoverCommandHandlerTest
    {
        private readonly IMediator mediator;
        private readonly IPlateau plateau;

        public RoverCommandHandlerTest()
        {
            var services = IoCBuilder.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            plateau = serviceProvider.GetService<IPlateau>();
            mediator = serviceProvider.GetService<IMediator>();
        }

        [Theory]
        [InlineData("1 2 N")]
        public void Should_Create_Rover(string roverLocation)
        {
            // Act
            var rover = mediator.Send(new CreateRoverCommand { Location = roverLocation, Plateau = plateau }).Result;

            // Assert
            Assert.Equal(2, rover.LocationY);
        }

        [Theory]
        [InlineData("3 3 E", "MMRMMRMRRM")]
        public void Should_Action_Rover(string roverLocation, string roverMovements)
        {
            // Act
            var rover = mediator.Send(new CreateRoverCommand { Location = roverLocation, Plateau = plateau }).Result;
            rover = mediator.Send(new ActionRoverCommand { Movements = roverMovements, Rover = rover }).Result;

            // Assert
            Assert.Equal("5 1 E", rover.GetLocationInformation());
        }
    }
}
