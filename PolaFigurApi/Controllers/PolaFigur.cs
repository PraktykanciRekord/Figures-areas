using Microsoft.AspNetCore.Mvc;
using MyApplication;
namespace PolaFigurApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PolaFigur : ControllerBase
{
    SquareArea sq = new(); 

    [HttpGet]
    public string Get(string a)
    {
        return SquareArea.SquareA(double.Parse(a)).ToString();
    }
}

