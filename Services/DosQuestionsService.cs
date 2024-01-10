
namespace Endpoint1.Services.Endpoint2;

    public class DosQuestionsService : IDosQuestionsService
    { 
        public string nameTime(string name, string time)
        {
            return $"How weird? Your name is {name}? And you woke up at {time}?";
        }
    }
