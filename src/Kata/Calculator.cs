using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if (string.IsNullOrEmpty(number))
                return 0;
            var numberArr = number.Split(',','\n').Select(num => int.Parse(num)).ToArray();

            return numberArr.Sum();
        }
    }
}