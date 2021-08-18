using BuildABookBag.DataStore;
using BuildABookBag.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildABookBag.Repositories
{
    public class BookBagRepostitory : IBookBagRepostitory
    {
        private readonly BookRequestDbContext _db;

        public BookBagRepostitory(BookRequestDbContext db)
        {
            _db = db;
        }

        public async Task AddNewBookBagRequest(BookBagRequest bookBagRequest)
        {

            await _db.BookBagRequests.AddAsync(bookBagRequest);
            await _db.SaveChangesAsync();
        }

    }
}
