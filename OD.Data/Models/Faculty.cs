namespace OD.Data.Models;

public class Faculty:BaseEntity
{
    //public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Department> Departments { get; set; } = null!;
}