using Microsoft.AspNetCore.Mvc;
using Endpoint1.Services.Endpoint3;

namespace Endpoint1.Controllers;

[ApiController]
[Route("[controller]")] 

    public class GreaterLesserController : ControllerBase
    {
        
        private readonly IGreaterLesserService _GreaterLesserService;
        public GreaterLesserController(IGreaterLesserService LessGreat){
            _GreaterLesserService = LessGreat;
        }

        [HttpGet]
        [Route("LessGreat/{firstNum}/{secondNum}")]

        public string lessGreat(string firstNum, string secondNum) 
        {
            return  _GreaterLesserService.lessGreat( firstNum, secondNum);
        }












    }
