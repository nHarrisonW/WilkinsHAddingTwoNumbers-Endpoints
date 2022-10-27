//N. Harrison Wilkins
//10-26-2022
//ADDING NUMBERS - ENDPOINTS
//THIS CONTROLLER WILL CONTROL ALL ENDPOINTS WITHIN THE PROJECT,  WILL WORK WITH WEB API'S
//PEER REVIEW BY : JERMY LAPHAM: WORKS GREAT IT ADDS NUMBER LIKE ITS SUPPOSED TO

//done
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
