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
        [RegularExpression(@"^[a-zA-Z]+\s[0-9]+$", ErrorMessage = "Please inesert street name and number of the house")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string LegalAddress { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z]+\s[0-9]+$", ErrorMessage = "Please inesert street name and number of the house")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string PhysicalAddress { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Personal code is invalid")]
        [Range(10000000000, 99999999999, ErrorMessage = "Registration code is too short")]
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
        public string Activities { get; set; }
        [Required]
        public bool  Services { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Regions { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Partners { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Number is invalid")]
        [Range(1, 99999999999, ErrorMessage = "Too small number")]
        public long LastYearTurnover { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Number is invalid")]
        [Range(1, 99999999999, ErrorMessage = "Too small number")]
        public long NextYearTurnover { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Structure { get; set; }
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
