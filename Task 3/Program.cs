using System;
//            Создать класс Book.Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
//Выведите на экран разными цветами при помощи метода  Show() название книги, имя автора и содержание.

namespace Task_3
{
    public class Book
    {
        public Title Title;
        public Author Author;
        public Content Content;

        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }

    public class Title
    {
        public string TitleName;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Title: " + TitleName);
            Console.ResetColor();
        }
    }
    public class Author
    {
        public string AuthorName;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Autor: " + AuthorName);
            Console.ResetColor();
        }
    }

    public class Content
    {
        public string ContentName;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Content: " + ContentName);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в Библиотеку, вы хотите добавить книгу? Yes/No");
            string answer = Convert.ToString(Console.ReadLine());
            switch (answer)
            {
                case "yes":
                    Book[] books = new Book[2];
                    Book book1 = CreateBook();
                    Book book2 = CreateBook();
                    books[0] = book1;
                    books[1] = book2;
                    for (int i = 0; i < books.Length; i++)
                    {
                        Console.WriteLine("Книга " + (i + 1));
                        books[i].Show();
                    }
                    break;
                case "no":
                    Console.WriteLine("Приходите в следующий раз.");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильное значение!");
                    break;
            }
        }
        public static Book CreateBook()
        {
                    Console.WriteLine("Введите название книги: ");
                    string t = Convert.ToString (Console.ReadLine());
                    Console.WriteLine("Введите автора книги: ");
                    string a = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите содержание книги: ");
                    string c = Convert.ToString(Console.ReadLine());

                    Title title = new Title();
                    title.TitleName = t;

                    Author author = new Author();
                    author.AuthorName = a;

                    Content content = new Content();
                    content.ContentName = c;
                    Book book = new Book();
                    book.Title = title;
                    book.Author = author;
                    book.Content = content;
            return book;
        }
    }
}
