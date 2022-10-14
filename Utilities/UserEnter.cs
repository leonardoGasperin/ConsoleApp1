using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class UserEnter
{
    static public void ConsoleInput()
    {
        Console.WriteLine("1-Inserir um produto\n2-Alterar informações de um produto\n3-Excluir um produto\n4-Pesquisar um produto" +
                          "\n5-Mostrar todos os produtos\nDigite qualquer outro caracter para sair");
        string? opt = Console.ReadLine();
        switch (opt)
        {
            case "1":
                RegisterProd.InsertProduct();
                break;
            case "2":
                EditProd.Editing();
                break;
            case "3":
                ExcludeProd.Exclude();
                break;
            case "4":
                SearchParams();
                break;
            case "5":
                PrintAllProducts();
                ConsoleInput();
                break;
            default:
                Exit();
                break;
        }
    }

    static private void SearchParams()
    {
        Produto produto = new(0, "", 0, 0, false, DateTime.Now, "");
        produto = produto.SearchProduct(InputStreamer.InputEditCodeStream());
        InputStreamer.InputPrintOneProductStream(produto);
    }

    private static void PrintAllProducts()
    {
        Produto produto = new(0, "", 0, 0, false, DateTime.Now, "");
        produto.PrintAllProducts();
    }

    private static void Exit(){
        Console.WriteLine("Deseja Sair? 0-Não 1-Sim");
        if((int)InputValidation.CheckInteger(Console.ReadLine()) == 0)
            ConsoleInput();
    }
}