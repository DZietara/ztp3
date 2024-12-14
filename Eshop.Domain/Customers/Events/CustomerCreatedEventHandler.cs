using Eshop.Domain.Orders.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Customers.Events
{
    public class CustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"CustomerCreatedEvent handled: {notification.CustomerId}");
            return Task.CompletedTask;
        }
    }
}