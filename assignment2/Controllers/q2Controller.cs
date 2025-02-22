using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Q2 : ControllerBase
    {
        // HTTP GET method to calculate the leftover cupcakes
        // Route: /Q2/Cupcakes
        [HttpGet("Cupcakes")]
        /// <summary>
        /// Calculates the leftover cupcakes based on the number of cupcakes baked (r) 
        /// and cupcakes sold (s). The formula is: 8 cupcakes per 'r' and 3 per 's'.
        /// The result will be the difference from 28 (base cupcakes).
        /// </summary>
        /// <param name="r">The number of cupcake batches with 8 cupcakes each</param>
        /// <param name="s">The number of cupcake batches with 3 cupcakes each</param>
        /// <returns>A string representing the leftover cupcakes after subtracting 28</returns>
        /// <example>
        /// Example:
        /// r = 3, s = 4
        /// Calculation: (3 * 8) + (4 * 3) = 24 + 12 = 36
        /// Leftover = 36 - 28 = 8
        /// Output: "8"
        /// </example>
        public string Cupcakes(int r, int s)
        {
            // Calculate the total number of cupcakes baked based on the input
            int calc = r * 8 + s * 3;

            // Calculate the leftover cupcakes after subtracting 28
            int leftover = calc - 28;

            // Return the result as a string
            return leftover.ToString();
        }
    }
}
