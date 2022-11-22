using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecttanglePer : ControllerBase
{
    Recttangle rc = new();

    [HttpGet]
    public string Get(string z, string c)
    {
        return Recttangle.rePem(double.Parse(z), double.Parse(c)).ToString();
    }
}

