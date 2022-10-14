<<<<<<< HEAD
﻿using ConsoleApp2;
using ConsoleApp2.Utilities;
=======
﻿using ConsoleApp1.Utilities;
using ConsoleApp1;
>>>>>>> cac31cf11a5dc2505a910d20ca615ba3ca15cc52

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
<<<<<<< HEAD
        
=======

>>>>>>> cac31cf11a5dc2505a910d20ca615ba3ca15cc52
        UserEnter.ConsoleInput();
    }
}