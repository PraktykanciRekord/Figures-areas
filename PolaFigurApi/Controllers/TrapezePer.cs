using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TrapezePer : ControllerBase
{
    Trapeze Tra = new();

    [HttpGet]
    public string Get(string aa, string bb, string cc, string dd)
    {
        return Trapeze.TrPe(double.Parse(aa), double.Parse(bb), double.Parse(cc), double.Parse(dd)).ToString();
    }
}

