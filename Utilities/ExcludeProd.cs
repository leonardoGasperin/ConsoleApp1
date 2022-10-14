using ConsoleApp2;
using ConsoleApp2.Utilities;

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