using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class ExcludeProd
{
    static public void Exclude()
    {
        Produto produto = new(0, "", 0, 0, false, DateTime.Now, "");
        produto = produto.SearchProduct(InputStreamer.InputEditCodeStream());
        if (produto != null)
            produto.Exclude(produto.Code);
        else
            Exclude();
    }
}