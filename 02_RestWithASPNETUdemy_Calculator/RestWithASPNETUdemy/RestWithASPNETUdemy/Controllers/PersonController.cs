using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {

            return BadRequest("Invalid Input");
        }


        //[HttpGet("sum/{firstNumber}/{secondNumber}")]
        //public IActionResult GetSum(string firstNumber, string secondNumber)
        //{

        //    //valida se o valo é numerico
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
        //        return Ok($"Soma: {sum.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");
        //}


        //[HttpGet("sub/{firstNumber}/{secondNumber}")]
        //public IActionResult GetSub(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
        //        return Ok($"Subtração: {sub.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");

        //}

        //[HttpGet("mut/{firstNumber}/{secondNumber}")]
        //public IActionResult GetMut(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var mut = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
        //        return Ok($"Multiplicação: {mut.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");

        //}

        //[HttpGet("div/{firstNumber}/{secondNumber}")]
        //public IActionResult GetDiv(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
        //        return Ok($"Divisão: {div.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");

        //}

        //[HttpGet("med/{firstNumber}/{secondNumber}")]
        //public IActionResult GetMed(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        //    {
        //        var med = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
        //        return Ok($"Média: {med.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");

        //}


        //[HttpGet("sqrt/{firstNumber}")]
        //public IActionResult GetSqr(string firstNumber, string secondNumber)
        //{
        //    if (IsNumeric(firstNumber))
        //    {
        //        var squaredRott = Math.Sqrt((double) ConvertToDecimal(firstNumber));
        //        return Ok($"Raiz Quadrada: {squaredRott.ToString()}");
        //    }

        //    return BadRequest("Invalid Input");

        //}




        //private bool IsNumeric(string strNumber)
        //{
        //    double number;

        //    bool isNumber = double.TryParse(
        //        strNumber, System.Globalization.NumberStyles.Any,
        //        System.Globalization.NumberFormatInfo.InvariantInfo,
        //        out number);

        //    return isNumber;

        //}

        //private decimal ConvertToDecimal(string strNumber)
        //{
        //    decimal decimalValue;

        //    if (decimal.TryParse(strNumber, out decimalValue))
        //    {
        //        return decimalValue;
        //    }

        //    return 0;
        //}

    }
}
