namespace OD.Data.Models;

public class Review
{
    public long Id { get; set; }
    public long PublicationId { get; set; }
    public Publication Publication { get; set; } = null!;
    public string Comment { get; set; } = string.Empty;
    public List<File> Files { get; set; } = null!;
}