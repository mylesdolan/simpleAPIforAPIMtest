
using Microsoft.AspNetCore.Mvc; // Required for ApiController, ControllerBase, and IActionResult
using System.Collections.Generic; // Required for List<T>


[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly List<DataModel> _data = new()
    {
        new DataModel { Id = 1, Name = "Sample 1" },
        new DataModel { Id = 2, Name = "Sample 2" }
    };

    [HttpGet]
    public IActionResult Get() => Ok(_data);
}