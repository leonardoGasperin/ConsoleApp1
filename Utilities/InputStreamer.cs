namespace ConsoleApp1.Utilities
{
    internal class InputStreamer
    {
        public static Produto InputStream()
        {
            int code;
            string? name;
            string? desc;
            decimal priceBrought;
            decimal priceSell;
            bool isActive;
            int minStringLength = 3;

            Console.WriteLine("Entre com o código do Produto:");
            code = ((int)InputValidation.CheckInteger(Console.ReadLine()));
            Console.WriteLine("Nome do produto: ");
            name = InputValidation.ValidatingStringInput(Console.ReadLine(), minStringLength);
            Console.WriteLine("Entre com a descrição do produto(opcional): ");
            desc = Console.ReadLine();
            Console.WriteLine("Digite o custo de compra:");
            priceBrought = InputValidation.CheckInteger(Console.ReadLine());
            Console.WriteLine("Digite o custo de venda:");
            priceSell = InputValidation.CheckInteger(Console.ReadLine());
            Console.WriteLine("0-Inativo 1-Ativo(padrão 0)");
            isActive = InputValidation.ValidatingBoolInput(Console.ReadLine());

            return new Produto(code, name, priceBrought, priceSell, isActive, new DateTime(1970, 01, 01), desc);
        }

        public static int InputEditCodeStream()
        {
            Console.WriteLine("Entre com o codigo do produto desejado");
            return (int)InputValidation.CheckInteger(Console.ReadLine());
        }

        public static void InputPrintOneProductStream(Produto produto)
        {
            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado");
                UserEnter.ConsoleInput();
            }
            else
                produto.PrintOneProduct(produto);
        }
    }
}
