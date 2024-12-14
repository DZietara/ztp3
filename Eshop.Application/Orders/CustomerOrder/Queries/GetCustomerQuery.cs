using Eshop.Application.Configuration.Queries;
using Eshop.Contracts.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Application.Orders.CustomerOrder.Queries
{
    public class GetCustomerQuery(Guid customerId) : IQuery<CustomerDto>
    {
        public Guid CustomerId { get; } = customerId;
    }
}