namespace ConsoleApp2.Utilities
{
    internal class InputStreamer
    {
        public static Produto InputProductStream()
        {
            Produto produto = new();

            Console.WriteLine("Entre com o código do Produto:");
            produto.Code = (int)InputValidation.CheckIsNumber(Console.ReadLine());
            Console.WriteLine("Nome do produto: ");
            produto.Name = InputValidation.ValidatingInput(Console.ReadLine());
            Console.WriteLine("Entre com a descrição do produto(opcional): ");
            produto.Desc = InputValidation.AcceptNullOrWhiteSpace(Console.ReadLine());
            Console.WriteLine("Digite o custo de compra:");
            produto.Price_brought = InputValidation.CheckIsNumber(Console.ReadLine());
            Console.WriteLine("Digite o custo de venda:");
            produto.Price_sell = InputValidation.CheckIsNumber(Console.ReadLine());
            Console.WriteLine("0-Inativo 1-Ativo(padrão 1)");
            produto.Active = InputValidation.ValidatingBoolInput(Console.ReadLine());

            return produto;
        }

        public static int InputEditCodeStream()
        {
            Console.WriteLine("Entre com o codigo do produto desejado");
            return (int)InputValidation.CheckIsNumber(Console.ReadLine());
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
