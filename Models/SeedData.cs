using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_Joisah_Sarles.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            FamazonDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<FamazonDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.books.Any())
            {
                context.books.AddRange(

                    new Book
                    {
                        bookId = 1,
                        title = "Les Miserables",
                        author = "Victor Hugo",
                        publisher = "Signet",
                        isbn = "978-0451419439",
                        category = "Fiction, Classic",
                        price = 9.95
                    },

                    new Book
                    {
                        bookId = 2,
                        title = "Team of Rivals",
                        author = "Doris Kearns Goodwin",
                        publisher = "Simon & Schuster",
                        isbn = "978-0743270755",
                        category = "Non-Fiction, Biography",
                        price = 14.58
                    },

                    new Book
                    {
                        bookId = 2,
                        title = "Team of Rivals",
                        author = "Doris Kearns Goodwin",
                        publisher = "Simon & Schuster",
                        isbn = "978-0743270755",
                        category = "Non-Fiction, Biography",
                        price = 14.58
                    },

                    ); ;

            }
        }

    }
}
