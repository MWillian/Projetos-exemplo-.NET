namespace CashFlow.Communication.Responses;

public class ResponseRegisterExpenseJson
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Id { get; set; }
}
