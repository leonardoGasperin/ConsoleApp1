using ConsoleApp1.Utilities;
using ConsoleApp1;

internal class ExcludeProd
{
    static public void Exclude()
    {
        Produto produto = new();
        produto = produto.TakeOneFromList(InputStreamer.InputEditCodeStream());
        if (produto != null)
            produto.Exclude(produto.Code);
        else
            Exclude();

        UserEnter.ConsoleInput();
    }
}