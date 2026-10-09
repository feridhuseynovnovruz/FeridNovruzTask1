using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public string ISBN;
    private bool isAvailable;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        isAvailable = true;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine(Title + " kitabı götürüldü.");
        }
        else
        {
            Console.WriteLine(Title + " kitabı artıq götürülüb!");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine(Title + " kitabı qaytarıldı.");
    }

    public void DisplayInfo()
    {
        string status = isAvailable ? "Mövcuddur" : "Götürülüb";
        Console.WriteLine("Kitab" + Title + "Müəllif" + Author + "Status" + status);
    }
}

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>();


        library.Add(new Book("Swd", "Jon Snow", "101"));
        library.Add(new Book("Lovers", "Marin Kitagawa", "102"));
        library.Add(new Book("Maracel", "Tapesnt Rimuru", "103"));
        library.Add(new Book("NoLife", "Yoia Kamuya", "104"));
        library.Add(new Book("Carpest", "Shougo Kinugasa", "105"));


        library[1].BorrowBook();
        library[2].BorrowBook();


        foreach (Book b in library)
        {
            b.DisplayInfo();
        }
    }
}