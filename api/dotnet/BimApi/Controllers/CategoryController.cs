using BimApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BimApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{

    [HttpGet]
    public IEnumerable<Metacategory> GetAllMetacategories()
    {
        var categoryService = new CategoryService();

        return categoryService.GetAllMetacategories();
    }

}