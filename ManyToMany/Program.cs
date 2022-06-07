using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DataAccess.Entities;

namespace ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine(Enter data)
            var book = new Book()
            {
                Id = Guid.NewGuid(),
                Name = "Harry Poter",
                Categories = new List<Category>
                {
                    new Category()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fantasy"
                    }
                }
            };

            LibraryDbContext context = new LibraryDbContext();
            context.Books.Add(book);
            context.SaveChanges();
            var books = context.Books.ToList();
        }
    }
}