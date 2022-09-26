namespace OD.Data.Interfaces.Author;

public class AuthorGetModel
{
    public string Search { get; set; } = string.Empty;

    public Page Page { get; set; } = new Page();
}