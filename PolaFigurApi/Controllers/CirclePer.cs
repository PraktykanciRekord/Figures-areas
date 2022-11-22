using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CirclePer : ControllerBase
{
    Circle cir = new();

    [HttpGet]
    public string Get(string rr)
    {
        return Circle.CirPer(double.Parse(rr)).ToString();
    }
}

