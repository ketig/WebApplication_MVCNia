namespace WebApplication_MVCNia.Models.Entities;

public class School
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Director { get; set; } = null!;

    public DateOnly FoundationDate { get; set; }

    public int StudentsQuantity { get; set; }
}
