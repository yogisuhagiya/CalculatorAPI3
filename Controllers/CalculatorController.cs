using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return Ok("Your Add total is: "+ sum);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            decimal difference = num1 - num2;
            return Ok("Your subtract total is: " +difference);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            decimal product = num1 * num2;
            return Ok("Your multiply total is: "+product);
        }

        [HttpGet("divide")]
        public IActionResult Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero.");
            }
            decimal quotient = num1 / num2;
            return Ok(quotient);
        }

        [HttpGet("modulo")]
        public IActionResult Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot perform modulo by zero.");
            }
            decimal remainder = num1 % num2;
            return Ok("Your Modulo total is: " + remainder);
        }
    }
}