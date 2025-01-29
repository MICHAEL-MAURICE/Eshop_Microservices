namespace CatalogeApi.Models;

public class Proudect
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }=default!;
    public decimal Price { get; set; }
    public string ImageFile { get; set; } = default!;
    public List<string> Category { get; set; } = new();
}
