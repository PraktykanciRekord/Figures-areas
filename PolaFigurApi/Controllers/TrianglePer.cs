using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TrianglePer : ControllerBase
{
    Triangle tr = new();

    [HttpGet]
    public string Get(string z, string x, string c)
    {
        return Triangle.TriPer(double.Parse(z), double.Parse(x), double.Parse(c)).ToString();
    }
}

