using Eshop.Domain.Customers.Events;
using Eshop.Domain.Customers.Rules;
using Eshop.Domain.Orders.Events;
using Eshop.Domain.SeedWork;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Eshop.Domain.Customers;

public class Customer : Entity, IAggregateRoot
{
    [BsonRepresentation(BsonType.String)]
    public string Name { get; private set; }

    public static Customer Create(string name)
    {
        CheckRule(new CustomerNameNotEmptyOnlyLettersRule(name));

        return new(name);
    }

    private Customer(string name) : base(Guid.NewGuid())
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));

        AddDomainEvent(new CustomerCreatedEvent(Id));
    }
}