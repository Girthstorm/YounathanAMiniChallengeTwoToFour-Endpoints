namespace Endpoint1.Services.Endpoint3;
    public class GreaterLesserService : IGreaterLesserService
    {
        double numberOne;
        double numberTwo;
        public string lessGreat(string firstNum, string secondNum)
        {
            if(double.TryParse(firstNum, out numberOne)&& double.TryParse(secondNum, out numberTwo))
            {
                if(numberOne == numberTwo)
                {
                    return $"Your first number: {numberOne} is equal to your second number: {numberTwo}. \n Your second number: {numberTwo} is equal to your first number: {numberOne}";
                } else if(numberOne > numberTwo){
                    return $"Your first number: {numberOne} is greater than your second number: {numberTwo}. \n Your second number: {numberTwo} is less than your first number: {numberOne}";
                } else {
                    return $"Your first number: {numberOne} is less than your second number: {numberTwo}. \n Your second number: {numberTwo} is greater than your first number: {numberOne}";
                }
            }
            return "One or more of your inputs are invalid, please ensure that you have entered numbers only and try again";
        }
    }
