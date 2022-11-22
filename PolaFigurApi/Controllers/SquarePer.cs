using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SquarePer : ControllerBase
{
    SquareArea pr = new();

    [HttpGet]
    public string Get(string b)
    {
        return SquareArea.SquareP(double.Parse(b)).ToString();
    }
}

