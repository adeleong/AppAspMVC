using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookDBContext> 
    {
        protected override void Seed(BookDBContext context)
        {
            context.Books.Add(new Book()
            {
                Name = "Teach Yourself C++ in 21 Days",
                PubDate = new DateTime(1995,1,1),
                Price = 49.63m,
                Genre = "Programing"
            });

            context.Books.Add(new Book()
            {
                Name = "Programing C#",
                PubDate = new DateTime(2000, 1, 1),
                Price = 69.63m,
                Genre = "Programing"
            });

            context.Books.Add(new Book()
            {
                Name = "Pro Windows 8 With XAML and C#",
                PubDate = new DateTime(2014, 1, 1),
                Price = 59.63m,
                Genre = "Programing"
            });

          //  base.Seed(context);
        }

    }
}