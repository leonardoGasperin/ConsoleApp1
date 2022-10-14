using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class EditProd
{
    public static void Editing()
    {
        Produto produto = new();
        produto = produto.TakeOneFromList(InputStreamer.InputEditCodeStream());
        ConfirmEdition(produto);
        UserEnter.ConsoleInput();
    }

    private static void ConfirmEdition(Produto produto)
    {
        if (produto.Code != -1)
            produto.Change(InputStreamer.InputProductStream());
        else
        {
            NoProductFound();
        }
    }

    public static void NoProductFound()
    {
        Console.WriteLine("Produto invalido");
        Editing();
    }
}