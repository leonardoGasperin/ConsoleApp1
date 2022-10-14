namespace ConsoleApp2.Utilities
{
    internal class InputValidation
    {
        public static decimal CheckInteger(string? inputValue)
        {
            decimal outValue;
            if (!decimal.TryParse(inputValue, out outValue) || outValue < 0)
                ValidatingNumericalInput(outValue);

            return outValue;
        }

        public static decimal ValidatingNumericalInput(decimal num)
        {
            Console.WriteLine("Digite um valor valido(somente Inteiros)");
            num = CheckInteger(Console.ReadLine());
            return num;
        }

        public static string ValidatingStringInput(string? inputValue, int size)
        {
            while (inputValue == null || inputValue.Length < size)
            {
                Console.WriteLine("Digite um valor valido: ");
                inputValue = Console.ReadLine();
            }
            return inputValue;
        }

        public static bool ValidatingBoolInput(string? inputValue)
        {
            int.TryParse(inputValue, out int isTrue);
            if (isTrue == 1)
                return true;
            else
                return false;
        }
    }
}
