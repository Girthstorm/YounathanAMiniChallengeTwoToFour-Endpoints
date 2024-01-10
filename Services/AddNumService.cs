namespace Endpoint1.Services.Endpoint1;

public class AddNumService : IAddNumService
{

    public string AddingNumbers(string num1, string num2)
    {
        double n1;
        double n2;
        if(double.TryParse(num1, out n1)&& double.TryParse(num1, out n2)){
            return $"{n1} + {n2} is equal to: {n1+n2}";
        } else {
            return "One or more of your inputs are invalid, please ensure that you have entered numbers only and try again";
        }
    }

}
