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
        [Required]
        public string CardHolderName { get; set; }
        [Required]
        public int LibraryCardNumber { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string AgeLevel { get; set; }
        [Required]
        public string PickUpLocation { get; set; }
        public string AdditionalComments { get; set; }

    }
}
