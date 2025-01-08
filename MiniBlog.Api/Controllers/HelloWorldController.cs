using Microsoft.AspNetCore.Mvc;

namespace MiniBlog.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : ControllerBase
{
    /// <summary>
    /// Health check endpoint
    /// </summary>
    /// <returns>A string written "Hello World"</returns>
    [HttpGet]
    public string SayHello()
    {
        return "Hello World";
    }
}
