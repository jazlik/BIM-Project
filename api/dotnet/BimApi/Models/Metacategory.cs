namespace BimApi;
public class Metacategory
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public List<Category>? CategoryList { get; set; }
}
