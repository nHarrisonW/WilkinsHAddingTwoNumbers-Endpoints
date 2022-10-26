using Microsoft.AspNetCore.Mvc;

namespace WilkinsHAddingTwoNumbers_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingController : ControllerBase
{
    [HttpGet]
    [Route("add/{numberOne}/{numberTwo}")]

    public int AddedNumbers(int numberOne = 0, int numberTwo = 0)
    {
        return numberOne + numberTwo;
    }
}
