namespace ConsoleApp2.Utilities
{
    internal class InputStreamer
    {
        public static Produto InputProductStream()
        {
            int minStringLength = 3;

            Produto produto = new();

            Console.WriteLine("Entre com o código do Produto:");
            produto.Code = ((int)InputValidation.CheckInteger(Console.ReadLine()));
            Console.WriteLine("Nome do produto: ");
            produto.Name = InputValidation.ValidatingStringInput(Console.ReadLine(), minStringLength);
            Console.WriteLine("Entre com a descrição do produto(opcional): ");
            produto.Desc = InputValidation.ValidatingStringInput(Console.ReadLine(), 0);
            Console.WriteLine("Digite o custo de compra:");
            produto.Price_brought = InputValidation.CheckInteger(Console.ReadLine());
            Console.WriteLine("Digite o custo de venda:");
            produto.Price_sell = InputValidation.CheckInteger(Console.ReadLine());
            Console.WriteLine("0-Inativo 1-Ativo(padrão 0)");
            produto.Active = InputValidation.ValidatingBoolInput(Console.ReadLine());

            return produto;
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
