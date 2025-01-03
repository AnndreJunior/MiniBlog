namespace MiniBlog.Presentation.Controllers;

public class HelloWorldController(ISender sender) : ApiController(sender)
{
    [HttpGet]
    public string HelloWorld() => "Hello World!";
}
