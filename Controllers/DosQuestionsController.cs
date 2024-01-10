using Endpoint1.Services.Endpoint2;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint1.Controllers;

[ApiController]
[Route("[controller]")]

    public class DosQuestionsController : ControllerBase
    {
        
        private readonly IDosQuestionsService _DosQuestionsService;
        public DosQuestionsController(IDosQuestionsService Question){
            _DosQuestionsService = Question;
        }

        [HttpGet]
        [Route("Question/{name}/{time}")]
        public string nameTime(string name, string time)
        {
            return _DosQuestionsService.nameTime(name, time);
        }
    }
