﻿using MathGameLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = Helpers.GetName();

        Menu menu = new Menu();

        menu.MainMenu(name);
    }
}