using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models
{
    public class CompanyModel : ClientModel
    {

        public CompanyModel()
        {
            IncorporationDate = DateTime.Now;
        }
        public int CompanyId { get; set; }
        [Required(ErrorMessage ="The field is required")]
        [RegularExpression(@"^[a-zA-Z\s]{1,}", ErrorMessage = "Please insert valid name")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z\s]{1,}", ErrorMessage = "Please insert valid name")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string TradingName { get; set; }
        
        public string LegalStatus { get; set; }
        
        public string CountryOfRegistration { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please inesert only street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string LegalAddress { get; set; }


        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert country code")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string LegalCountryCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert city or town name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string LegalCityOrTown { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string LegalCounty { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "House number is invalid")]
        [Range(0, 99999999999, ErrorMessage = "House number is too short")]
        public string LegalHouseNumber { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z]+[0-9]+$", ErrorMessage = "Postal code is invalid")]
        public string LegalPostalCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert only street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string PhysicalAddress { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert country code")]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string PhysicalCountryCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert city or town name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string PhysicalCityOrTown { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please insert street name")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string PhysicalCounty { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "House number is invalid")]
        [Range(0, 99999999999, ErrorMessage = "House number is too short")]
        public string PhysicalHouseNumber { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z]+[0-9]+$", ErrorMessage = "Postal code is invalid")]
        public string PhysicalPostalCode { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Registration code is invalid")]
        [Range(10000000000, 99999999999, ErrorMessage = "Registration code is too short (11 digits)")]
        public long RegistrationCode { get; set; }
        
        public DateTime IncorporationDate { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[+]+[0-9]+$", ErrorMessage = "Number form is country code and digits")]
        [MaxLength(12, ErrorMessage = "Phone number is too long")]
        public string CompanyPhoneNumber { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [EmailAddress]
        public string CompanyEmail { get; set; }
       
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Regions { get; set; }
        
        [Required(ErrorMessage = "The field is required")]
        public bool License { get; set; }
        [Url]
        [Required(ErrorMessage = "The field is required")]
        public string Website { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Expected { get; set; }

    }
}
