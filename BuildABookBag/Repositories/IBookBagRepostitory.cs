using BuildABookBag.Models;
using System.Threading.Tasks;

namespace BuildABookBag.Repositories
{
    public interface IBookBagRepostitory
    {
        Task AddNewBookBagRequest(BookBagRequest bookBagRequest);
    }
}