using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BronzeCountController : ControllerBase
    {
   /// <summary>
        /// Determines the score required for bronze level and how many participants achieved this score.
        /// </summary>
        /// <param name="scores">A list of participant scores.</param>
        /// <returns>A tuple containing the bronze level score and the number of participants who achieved it.</returns>
        /// <example>
        ///[70, 62, 58, 73]
        /// 1. Sort the scores in descending order: [73, 70, 62, 58]
        /// 2. The third distinct score is the bronze level score: 62
        /// 3. Count how many participants have the bronze score: 1
        ///
        /// Output:
        /// { "BronzeScore": 62, "Count": 1 }
        /// </example
        [HttpPost("calculate-bronze")]
        public IActionResult CalculateBronze([FromBody] List<int> scores)
        {
            // Ensure there are at least three distinct scores
            if (scores.Distinct().Count() < 3)
            {
                return BadRequest("There must be at least three distinct scores.");
            }

            // Sort the scores in descending order
            var sortedScores = scores.OrderByDescending(score => score).ToList();

            // Find the third distinct score (bronze level score)
            int bronzeScore = sortedScores.Distinct().Skip(2).First();

            // Count how many participants achieved the bronze level score
            int bronzeCount = scores.Count(score => score == bronzeScore);

            // Return the bronze level score and the count of participants
            return Ok(new { BronzeScore = bronzeScore, Count = bronzeCount });
        }
    }
}
