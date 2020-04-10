using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models
{
    public class QuestionnaireModel
    {

        public int QuestionnaireId { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string CurrenciesToBeBought { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string CurrenciesToBeReceived { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string CurrenciesToBeSent { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string CurrenciesToBeSold { get; set; }

        public string ExpectedIncomingPaymentsSourceCountries { get; set; }

        public string ExpectedOutgoingPaymentsDestinationCountries { get; set; }

        public string EstimatedAverageIncomingTransactionValue { get; set; }

        public string EstimatedAverageOutgoingTransactionValue { get; set; }

        public string EstimatedNextYearsTurnover { get; set; }

        public string EstimatedOutgoingTransactionTurnover { get; set; }

        public string EstimatedAverageIncomingTransactionVolume { get; set; }

        public string EstimatedAverageOutgoingTransactionVolume { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Activities { get; set; }
        
        [Required(ErrorMessage = "The field is required")]
        public bool Services { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Partners { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string Structure { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "The field is required")]
        public string ReceivedServices { get; set; }

        public string BussinessAccounts { get; set; }

        public string AmlProcedure { get; set; }
    }


}

