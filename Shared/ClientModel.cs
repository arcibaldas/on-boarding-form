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
        [Range(10000000000, 99999999999, ErrorMessage = "Personal code is too short")]
        public long PersonalCode { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert valid name")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Citizenship { get; set; }

        public string CountryOfResidence { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert country code")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert city or town name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string CityOrTown { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string County { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "House number is invalid")]
        [Range(0, 99999999999, ErrorMessage = "Personal code is too short")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z]+[0-9]+$", ErrorMessage = "Postal code is invalid")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert valid surname")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Surname { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[+]+[0-9]+$", ErrorMessage = "Number form is country code and digits")]
        [MaxLength(12, ErrorMessage = "Phone number is too long")]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string BasisfOfRepresentation { get; set; }

        public bool isSubmitted { get; set; } = false;

        public string Occupation { get; set; }

        public string SharesOwned { get; set; }

      
        public bool Politics { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public int isCeo { get; set; }

        
        public int ClientCounter { get; set; }

    }
}
