using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class FormController : ControllerBase
{
    [HttpGet]
    public string Get() => "Hello from API";

}