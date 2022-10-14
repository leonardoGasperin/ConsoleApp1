using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class RegisterProd
{
    public static void InsertProduct(bool isEditing = false)
    {
        Produto produto = InputStreamer.InputStream();
        produto.InsertProduct(produto);
    }
}