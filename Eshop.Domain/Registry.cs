using Eshop.Domain.Customers.Events;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Eshop.Domain;

public static class Registry
{
    public static void RegistryDomain(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Registry).Assembly));

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CustomerCreatedEvent>());
    }
}