using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Exception;
using CommonTestsUtilities.Requests;

namespace Validators.Test.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }

    [Theory]
    [InlineData("")]
    [InlineData("        ")]
    [InlineData(null)]
    public void ErrorTitleEmpty(string title)
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Title = title;

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains(result.Errors, x => x.ErrorMessage.Equals(ResourceErrorMessages.TITLE_IS_REQUIRED));
    }

    [Fact]
    public void ErrorDateFuture()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Date = DateTime.Now.AddDays(1);

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains(result.Errors, x => x.ErrorMessage.Equals(ResourceErrorMessages.EXPENSE_DATE_CANNOT_BE_FUTURE));
        Assert.False(request.Date < DateTime.Now);
    }

    [Fact]
    public void ErrorInvalidPaymentType()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Payment = (PaymentType)10;

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains(result.Errors, x => x.ErrorMessage.Equals(ResourceErrorMessages.VALID_PAYMENT));
    }

    [Theory]
    [InlineData(-7)]
    [InlineData(-2)]
    public void ErrorAmmountLessThanZero(decimal ammount)
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Ammount = ammount;

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains(result.Errors, x => x.ErrorMessage.Equals(ResourceErrorMessages.THE_AMMOUNT_CANNOT_BE_NEGATIVE));
    }
}
