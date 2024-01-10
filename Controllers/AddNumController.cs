using Endpoint1.Services.Endpoint1;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint1.Controllers;

[ApiController]
[Route("[controller]")]

    public class AddNumController : ControllerBase
    {

        private readonly IAddNumService _AddNumService;
        public AddNumController(IAddNumService Adding){
            _AddNumService = Adding;
        }

        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public string AddingNumbers(string num1, string num2)
        {
            return  _AddNumService.AddingNumbers(num1, num2);
        }
    }
