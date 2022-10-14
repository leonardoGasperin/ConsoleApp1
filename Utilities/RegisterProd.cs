using ConsoleApp2;
using ConsoleApp2.Utilities;

internal class RegisterProd
{
    public static void InsertProduct(bool isEditing = false)
    {
        Produto produto = InputStreamer.InputProductStream();
        produto.InsertProduct(produto);
        UserEnter.ConsoleInput();
    }
}