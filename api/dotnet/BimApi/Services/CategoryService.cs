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
            CategoryList = GetAllCategories()
        });

        return metacategories;
    }

    public List<Category> GetAllCategories()
    {
        var categoryList = new List<Category>();
        categoryList.Add(new Category { Id = Guid.NewGuid(), Name = "Beams" });
        categoryList.Add(new Category { Id = Guid.NewGuid(), Name = "Lintels" });

        return categoryList;
    }


    public Category GetCategoryByName(String searchName)
    {
        var categoryList = GetAllCategories();

        var result = categoryList.Find(x => x.Name == searchName);

        return result ?? new Category();
    }

}