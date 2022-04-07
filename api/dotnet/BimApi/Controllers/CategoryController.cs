using BimApi.Services;
using Microsoft.AspNetCore.Mvc;
using Mapster;

namespace BimApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{

    [HttpGet]
    [Route("GetAllMetacategories")]
    public IEnumerable<MetacategoryViewModel> GetAllMetacategories()
    {
        var categoryService = new CategoryService();
        var metacategories = categoryService.GetAllMetacategories();

        // Mapping foreach approach
        var resultForeach = new List<MetacategoryViewModel>();
        foreach (Metacategory metacategory in metacategories)
        {
            resultForeach.Add(new MetacategoryViewModel
            {
                Id = metacategory.Id,
                Name = metacategory.Name,
                EuName = "EU_" + metacategory.Name,
                CategoryList = metacategory.CategoryList
            });
        }

        // Mapping select approach
        var resultSelect = metacategories.Select(metacategory => new MetacategoryViewModel
        {
            Id = metacategory.Id,
            Name = metacategory.Name,
            EuName = "EU_" + metacategory.Name,
            CategoryList = metacategory.CategoryList
        }).ToList();

        // Automatic mapping
        var resultMapster = metacategories.Adapt<List<MetacategoryViewModel>>();

        return resultForeach;
    }

    [HttpGet]
    [Route("GetCategoryByName")]
    public CategoryViewModel GetCategoryByName(String searchName)
    {

        var categoryService = new CategoryService();
        var category = categoryService.GetCategoryByName(searchName);
        var result = new CategoryViewModel { Id = category.Id, Name = category.Name };

        return result;

    }

}