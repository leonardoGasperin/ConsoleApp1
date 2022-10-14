﻿using ConsoleApp1;
using ConsoleApp1.Utilities;

internal class EditProd
{
    public static void Editing()
    {
        Produto produto = new(0, "", 0, 0, false, DateTime.Now, "");
        produto = produto.TakeOneFromList(InputStreamer.InputEditCodeStream());
        ConfirmEdition(produto);
    }

    private static void ConfirmEdition(Produto produto)
    {
        if (produto != null)
            produto.Change(InputStreamer.InputProductStream());
        else
        {
            Console.WriteLine("Produto invalido");
            Editing();
        }
    }
}