using MarsRover.Application;
using MarsRover.Domain.Enums;
using MarsRover.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MarsRover.Test
{
    public class RoverTest
    {
        private readonly IRover rover;

        public RoverTest()
        {
            var services = IoCBuilder.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            rover = serviceProvider.GetService<IRover>();
        }

        [Fact]
        public void Rover_Should_Turn_Left()
        {
            // Arrange
            rover.Direction = Direction.N;

            // Act
            rover.TurnLeft();

            // Assert
            Assert.Equal(Direction.W, rover.Direction);
        }

        [Fact]
        public void Rover_Should_Turn_Right()
        {
            // Arrange
            rover.Direction = Direction.N;

            // Act
            rover.TurnRight();

            // Assert
            Assert.Equal(Direction.E, rover.Direction);
        }

        [Fact]
        public void Rover_Should_Move()
        {
            // Arrange
            rover.LocationY = 5;
            rover.Direction = Direction.N;

            // Act
            rover.Move();

            // Assert
            Assert.Equal(6, rover.LocationY);
        }

        [Fact]
        public void Rover_LocationX_Should_Correct()
        {
            // Arrange
            rover.LocationX = 4;

            // Assert
            Assert.Equal(4, rover.LocationX);
        }

        [Fact]
        public void Rover_LocationY_Should_Correct()
        {
            // Arrange
            rover.LocationY = 5;

            // Assert
            Assert.Equal(5, rover.LocationY);
        }

        [Fact]
        public void Rover_Direction_Should_Correct()
        {
            // Arrange
            rover.Direction = Direction.N;

            // Assert
            Assert.Equal(Direction.N, rover.Direction);
        }
    }
}
