using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers;

[ApiController]
[Route("api/q1")]

public class Q1 : ControllerBase
{
     /// <summary>
    /// Calculates the score for a delivery robot based on the number of deliveries and collisions.
    /// The score is calculated as: (Deliveries * 50) - (Collisions * 10)
    /// If the number of deliveries is greater than the number of collisions, an additional 500 points is added.
    /// </summary>
    /// <param name="collision">The number of collisions the robot had.</param>
    /// <param name="deliveries">The number of deliveries the robot made.</param>
    /// <returns>The calculated score based on the robot's performance.</returns>
    /// <example>
    /// Input:
    /// collision = 3
    /// deliveries = 8
    ///
    /// Steps:
    /// 1. Calculate the base score: (8 * 50) - (3 * 10) = 400 - 30 = 370
    /// 2. Since deliveries > collisions (8 > 3), add an additional 500 points to the score: 370 + 500 = 870
    ///
    /// Output:
    /// 870
    /// </example>

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

