namespace MiniBlog.Presentation.Controllers;

[Route("[controller]")]
[ApiController]
public abstract class ApiController(ISender sender) : ControllerBase
{
    protected readonly ISender _sender = sender;
}
