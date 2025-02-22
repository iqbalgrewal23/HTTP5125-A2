using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CSharpAssignment2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class Q4Controller : ControllerBase
       /// <summary>
        /// Counts how many players have a star rating greater than 40.
        /// A player's star rating is calculated as: (2 * Points per game) + Rebounds per game.
        /// </summary>
        /// <param name="players">A list of player stats where each player has Points (P) and Rebounds (R) per game.</param>
        /// <returns>The count of players who have a star rating greater than 40.</returns>
        /// <example>
        /// Input:
        /// [
        ///   { "P": 20, "R": 15 },
        ///   { "P": 18, "R": 10 },
        ///   { "P": 25, "R": 10 }
        /// ]
        ///
        /// Steps:
        /// - Calculate the star rating for each player:
        ///   - Player 1: (2 * 20) + 15 = 55 (greater than 40)
        ///   - Player 2: (2 * 18) + 10 = 46 (greater than 40)
        ///   - Player 3: (2 * 25) + 10 = 60 (greater than 40)
        /// - All three players have a star rating greater than 40, so the result is 3.
        ///
        /// Output:
        /// { "starPlayers": 3 }
        /// </example>
    {
      [HttpPost("count-stars")]
    public IActionResult CountStarPlayers([FromBody] List<PlayerStats> players)
    {
        int count = 0;

        foreach (var player in players)
        {
            double starRating = (2 * player.P) + player.R;
            if (starRating > 40)
            {
                count++;
            }
        }

        return Ok(new { starPlayers = count });
    }
}

public class PlayerStats
{
    public int P { get; set; }  // Points per game
    public int R { get; set; }  // Rebounds per game
}
}
  