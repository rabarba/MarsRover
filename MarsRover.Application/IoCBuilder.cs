using MarsRover.Application.Plateau.Commands.CreatePlateau;
using MarsRover.Domain.Enums;
using MarsRover.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MarsRover.Application
{
    public static class IoCBuilder
    {
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IRover, Domain.Rover>();

            services.AddTransient<IPlateau, Domain.Plateau>();

            services.AddMediatR(typeof(CreatePlateauCommand).GetTypeInfo().Assembly);

            return services;
        }
    }
}
