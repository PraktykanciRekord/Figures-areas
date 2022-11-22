using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TrapezeAr : ControllerBase
{
    Trapeze Tra = new();

    [HttpGet]
    public string Get(string a, string b, string h)
    {
        return Trapeze.TrAr(double.Parse(a), double.Parse(b), double.Parse(h)).ToString();
    }
}

