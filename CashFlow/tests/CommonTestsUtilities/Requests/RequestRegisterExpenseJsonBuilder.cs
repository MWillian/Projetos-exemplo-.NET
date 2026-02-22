using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestsUtilities.Requests;

public static class RequestRegisterExpenseJsonBuilder
{
    public static RequestRegisterExpenseJson Build()
    {
        return new Faker<RequestRegisterExpenseJson>()
             .RuleFor(r => r.Title, faker => faker.Commerce.ProductName())
             .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
             .RuleFor(r => r.Date, faker => faker.Date.Past())
             .RuleFor(r => r.Payment, faker => faker.PickRandom<PaymentType>())
             .RuleFor(r => r.Ammount, faker => faker.Random.Decimal(min: 1, max: 10000));
    }
}
