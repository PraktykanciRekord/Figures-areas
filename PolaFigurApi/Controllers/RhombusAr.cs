using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RhombusAr : ControllerBase
{
    Rhombus rho = new();

    [HttpGet]
    public string Get(string e, string f)
    {
        return Rhombus.RhoArea(double.Parse(e), double.Parse(f)).ToString();
    }
}

