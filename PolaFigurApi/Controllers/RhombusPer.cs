using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RhombusPer : ControllerBase
{
    Rhombus rho = new();

    [HttpGet]
    public string Get(string b)
    {
        return Rhombus.rhomPer(double.Parse(b)).ToString();
    }
}

