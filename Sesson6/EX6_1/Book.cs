using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public Book(int id, string title, string author, string publisher, int year, decimal price)
    {
        Id = id;
        Title = title;
        Author = author;
        Publisher = publisher;
        Year = year;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, Published by {Publisher} in {Year}, Price: {Price:C}";
    }
}
