namespace f_API.Communication.Request;

public class RequestChangePassWordJson
{
    public string CurrentPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}
