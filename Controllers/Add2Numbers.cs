using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MonterrosaDMC2Add2Numbers_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2Numbers : ControllerBase
    {
        [HttpGet]
        [Route("AddNumbers")]

        public string AddNumbers(int firstNumber, int secondNumber) {
            int sum = firstNumber + secondNumber;
            return $"The sum of {firstNumber} and {secondNumber} is {sum}";
        }
    }
}