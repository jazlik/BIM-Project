namespace BimApi;
public class MetacategoryViewModel
{
    public Guid Id { get; set; }
    public String? Name { get; set; }
    public String? EuName { get; set; }
    public List<Category>? CategoryList { get; set; }
}
