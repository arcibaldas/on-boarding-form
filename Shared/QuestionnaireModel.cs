using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class QuestionnaireModel
    {

        public int QuestionnaireId { get; set; }
        public string CurrenciesToBeBought { get; set; }

        public string CurrenciesToBeReceived { get; set; }

        public string CurrenciesToBeSent { get; set; }

        public string CurrenciesToBeSold { get; set; }

        public string ExpectedIncomingPaymentsSourceCountries { get; set; }

        public string ExpectedOutgoingPaymentsDestinationCountries { get; set; }

        public string EstimatedAverageIncomingTransactionValue { get; set; }

        public string EstimatedAverageOutgoingTransactionValue { get; set; }

        public string EstimatedNextYearsTurnover { get; set; }

        public string EstimatedOutgoingTransactionTurnover { get; set; }

        public string EstimatedAverageIncomingTransactionVolume { get; set; }

        public string EstimatedAverageOutgoingTransactionVolume { get; set; }


    }


}

