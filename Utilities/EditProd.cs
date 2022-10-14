using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class EditProd
{
    public static void Editing()
    {
        Produto produto = new(0, "", 0, 0, false, DateTime.Now, "");
        produto = produto.SearchProduct(InputStreamer.InputEditCodeStream());
        ConfirmEdition(produto);
    }

    private static void ConfirmEdition(Produto produto)
    {
        if (produto != null)
            produto.Change(InputStreamer.InputStream());
        else
        {
            Console.WriteLine("Produto invalido");
            Editing();
        }
    }
}