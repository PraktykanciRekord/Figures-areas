using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TriangleAr : ControllerBase
{
    Triangle tr = new();

    [HttpGet]
    public string Get(string a, string h)
    {
        return Triangle.TriAr(double.Parse(a), double.Parse(h)).ToString();
    }
}

