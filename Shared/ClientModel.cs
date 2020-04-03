using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Shared.Models
{
    public class ClientModel
    {
        public ClientModel()
        {
            BirthDate = DateTime.Now;
        }
        public int Id { get; set; }

        public int CeoId { get; set; }
        public int UboId { get; set; }

        public int RepresentativeId { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Personal code is invalid")]
        [Range(10000000000,99999999999,ErrorMessage ="Code must be 11 digits")]
        public long PersonalCode { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert valid name")]
        [MinLength(2,ErrorMessage ="Name is too short")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; }

        public string CountryOfResidence { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+\s[0-9]+$",ErrorMessage ="Please inesert street name and number of the house")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert valid surname")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[+]+[0-9]+$", ErrorMessage = "Number form is (+370)+digits")]
        [MaxLength(12,ErrorMessage ="Phone number should be 10 digits")]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string BasisfOfRepresentation { get; set; }

        public bool isSumbitted { get; set; } = false;

        public string Occupation { get; set; }

        public string SharesOwned { get; set; }

    }
}
