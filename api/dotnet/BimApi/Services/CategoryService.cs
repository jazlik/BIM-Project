namespace BimApi.Services;

public class CategoryService
{
    public List<Metacategory> GetAllMetacategories()
    {
        var metacategories = new List<Metacategory>();
        metacategories.Add(new Metacategory
        {
            Id = Guid.NewGuid(),
            Name = "Construction",
            CategoryList = GetCategories()
        });

        return metacategories;
    }

    public List<Category> GetCategories()
    {
        var categoryList = new List<Category>();
        categoryList.Add(new Category { Id = Guid.NewGuid(), Name = "Beams" });
        categoryList.Add(new Category { Id = Guid.NewGuid(), Name = "Lintels" });

        return categoryList;
    }

}