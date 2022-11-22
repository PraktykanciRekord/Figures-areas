using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CircleAr : ControllerBase
{
    Circle cir = new();

    [HttpGet]
    public string Get(string r)
    {
        return Circle.CirAr(double.Parse(r)).ToString();
    }
}

