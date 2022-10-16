using System.Drawing;

namespace ConsoleApp2.Utilities
{
    static class InputValidation
    {
        public static decimal CheckIsNumber(string? inputValue)
        {
            inputValue = ValidatingInput(inputValue);
            if (decimal.TryParse(inputValue, out decimal result))
                return result;
            else
               return CheckIsNumber(ValidateFail());
        }

        public static string ValidatingInput(this string? inputValue)
        {
            if (String.IsNullOrWhiteSpace(inputValue))
                inputValue = ValidateFail();
            return inputValue;
        }

        public static string ValidateFail()
        {
            Console.WriteLine("Digite um valor valido:");
            return ValidatingInput(Console.ReadLine());
        }

        public static string AcceptNullOrWhiteSpace(string? inputValue)
        {
            if (String.IsNullOrWhiteSpace(inputValue))
                return "";
            return inputValue;
        }

        public static bool ValidatingBoolInput(string? inputValue)
        {
            return bool.TryParse(inputValue, out bool isTrue) ? isTrue : false; 
        }
    }
}
