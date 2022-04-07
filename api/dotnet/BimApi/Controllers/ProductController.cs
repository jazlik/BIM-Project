using Microsoft.AspNetCore.Mvc;

namespace BimApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IEnumerable<int> GetProducts()
    {
        var result = new List<int>();
        result.Add(2);
        result.Add(3);

        return result;
    }

}