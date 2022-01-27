using StockMSFile.Menus;
using StockMSFile.Repositories;
using System;

namespace StockMSFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("====== Welcome to CLH Store ======");
            Console.WriteLine("==================================");

            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }
    }
}
