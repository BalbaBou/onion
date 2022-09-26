using OD.Data.Enums;

namespace OD.Data.Interfaces.Auth;

public class LoginResponse
{
    public long Id { get; set; }
    public string Token { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string SureName { get; set; } = string.Empty;
    public EnumUserRole Role { get; set; }
}