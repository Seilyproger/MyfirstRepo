using System;
using project;

namespace a
{
    class Program
    {
        static void Main()
        { 
        //   Player player1 = new Player("Geralt",100,10);
        //   Player player2 = new Player("Lytik",60,7);
        //   System.Console.WriteLine("--- Битва начинается! ---");
        //   player1.ShowInfo();
        //   player2.ShowInfo();
        //   System.Console.WriteLine("--- Lytik получил урон ---");
        //   player2.TakeDamage(10);
        //   player2.ShowInfo();
        //   System.Console.WriteLine("--- Стасистика ---");
        //   System.Console.WriteLine("Всего создано игроков: " + Player.GetPlayerCount());
          Book book1 = new Book("Богатый папа бедный папа","Я",400);
          Book book2 = new Book("Колобок","Я",100);
          book1.ShowInfo();
          book2.ShowInfo();
          System.Console.WriteLine("--- Начиная читать ---");
          book1.ReadPages(100);
          book1.ShowInfo();
          System.Console.WriteLine("--- Статистика ---");
          System.Console.WriteLine("Всего книг у тебя есть: " + Book.BooksCount());



        }



    }
}



