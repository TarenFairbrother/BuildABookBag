using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildABookBag.Models
{
    public class BookBagRequest
    {
        [Key]
        public int BookBagId { get; set; }
        public string CardHolderName { get; set; }
        public int LibraryCardNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AgeLevel { get; set; }
        public string PickUpLocation { get; set; }
        public string AdditionalComments { get; set; }

    }
}
