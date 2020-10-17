using MarsRover.Application;
using MarsRover.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MarsRover.Test
{
    public class PlateauTest
    {
        private readonly IPlateau plateau;
        private readonly IRover rover;

        public PlateauTest()
        {
            var services = IoCBuilder.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            plateau = serviceProvider.GetService<IPlateau>();
            rover = serviceProvider.GetService<IRover>();
        }

        [Fact]
        public void Plateau_SizeX_Should_Correct()
        {
            // Arrange
            plateau.SizeX = 4;

            // Assert
            Assert.Equal(4, plateau.SizeX);
        }

        [Fact]
        public void Plateau_SizeY_Should_Correct()
        {
            // Arrange
            plateau.SizeY = 5;

            // Assert
            Assert.Equal(5, plateau.SizeY);
        }

        [Fact]
        public void Plateau_Should_Add_Rover()
        {
            // Arrange
            plateau.AddRover(rover);
            plateau.AddRover(rover);

            // Assert
            Assert.Equal(2, plateau.Rovers.Count);
        }
    }
}
