using BuildABookBag.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildABookBag.DataStore
{
    public class BookRequestDbContext : DbContext
    {

        public BookRequestDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BookBagRequest> BookBagRequests { get; set; }
    }
}
