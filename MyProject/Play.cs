using System; 
namespace project
{
    class Book{
        private string title;
        private string author;
        private int pages;
        private int read;
        public static int CountBook;
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            CountBook ++;
        }
        public Book()
        {
            CountBook++;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Название книги: " + title + " Автор книги: " + author + " Количество страниц: " + pages);
        }
        public void  ReadPages(int read)
        {
            pages = pages - read;
            System.Console.WriteLine("Ты прочитал " + read + " и тебе осталось прочитать " + pages + " страниц!");
        }
        public static int BooksCount()
        {
            return CountBook;
        }
             
    }
}