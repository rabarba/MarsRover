using MarsRover.Application.Plateau.Commands.CreatePlateau;
using MarsRover.Application.Rover.Commands.ActionRover;
using MarsRover.Application.Rover.Commands.CreateRover;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover.Application
{
    class Program
    {

        static void Main()
        {
            var services = IoCBuilder.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var mediatr = serviceProvider.GetService<IMediator>();

            Console.WriteLine("--- Mars Rover ---\n");

            Console.Write("Please Enter Plateau Size : ");
            var plateauSize = Console.ReadLine();
            var plateau = mediatr.Send(new CreatePlateauCommand { Size = plateauSize }).Result;

            while (true)
            {
                Console.Write("Please Enter Rover Location : ");
                var roverLocation = Console.ReadLine();
                var rover = mediatr.Send(new CreateRoverCommand { Location = roverLocation, Plateau = plateau }).Result;

                Console.Write("Please Enter Rover Movements : ");
                var roverMovements = Console.ReadLine();
                rover = mediatr.Send(new ActionRoverCommand { Movements = roverMovements, Rover = rover }).Result;

                Console.WriteLine("Would you like to add an extra rover? (Y/N):" );
                var key = Console.ReadLine();
                if (key != "Y") break;
            }

            foreach (var rover in plateau.Rovers)
            {
                Console.WriteLine(rover.GetLocationInformation());
            }

        }
    }
}
