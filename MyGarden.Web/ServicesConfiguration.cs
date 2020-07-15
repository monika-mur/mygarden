using Garden.Application.Commands.GardenKnowledge;
using Garden.Application.Queries.GardenKnowledge;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyGarden.Web
{
    public static class ServicesConfiguration
    {
        public static void AddCommandQueryHandlers(this IServiceCollection services, Type handlerInterface)
        {
            var handlers = typeof(AddPlantCharacteristicsCommandHandler).Assembly.GetTypes()
                .Where(h => h.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface) != null);

            handlers = handlers.Concat(typeof(PlantsCharacteristicsQueryHandler).Assembly.GetTypes()
                .Where(h => h.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface) != null));

            foreach (var handler in handlers)
            {
                services.AddScoped(handler.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface), handler);
            }
        }
    }
}
