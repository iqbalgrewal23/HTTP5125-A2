using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers;

[ApiController]
[Route("api/q1")]

public class Q1 : ControllerBase
{

        [HttpPost("delivedroid")]
         [Consumes("application/x-www-form-urlencoded")]
        public int CalculateScore([FromForm] int collision, [FromForm] int deliveries)
        {
            int total = (deliveries * 50) - (collision * 10);
            if (deliveries > collision)
            {
                total=total+ 500;
            }
            return total;
        }
    }

