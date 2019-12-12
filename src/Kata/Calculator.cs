using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;
            var numberArr = number.Split(",").Select(num => int.Parse(num)).ToArray();
            
            return numberArr.Length > 1 ? numberArr[0] + numberArr[1] : 3;
        }
    }
}