using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecttangleAr : ControllerBase
{
    Recttangle rc = new();

    [HttpGet]
    public string Get(string q, string w)
    {
        return Recttangle.recArea(double.Parse(q), double.Parse(w)).ToString();
    }
}

