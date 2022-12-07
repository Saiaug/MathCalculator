using Microsoft.AspNetCore.Mvc;
using MathCalculator;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Http;
namespace MathCalculator.Controller
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class CalculatorController : ControllerBase
    {
        private readonly IMath _math;

        public CalculatorController(IMath math)
        {
            _math = math;
        }

        [HttpGet]
        [Route("Add")]
        public int Add(int a, int b)
        {
            //IMath d = new Math();
            int c = _math.sum(a, b);
            return c;
        }

        [HttpGet]
        [Route("subtract")]
        public int subtract(int a, int b)
        {
            //IMath d = new Math();
            int c = _math.sub(a, b);
            return c;
        }

        [HttpGet]
        [Route("multiply")]
        public int muliply(int a, int b)
        {
            //IMath d = new Math();
            int c = _math.mul(a, b);
            return c;
        }

        [HttpGet]
        [Route("division")]
        public int division(int a, int b)
        {
            //IMath d = new Math();
            int c = _math.div(a, b);
            return c;
        }




        /* public IActionResult Index()
         {
             return View();
         }*/
    }
}