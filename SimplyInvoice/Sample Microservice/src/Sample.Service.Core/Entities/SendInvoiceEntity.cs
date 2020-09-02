using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service.Core.Entities
{
    public class SendInvoiceEntity
    {
        public string userId { get; set; }
        public string SubKey { get; set; }
        public string uid { get; set; }
        public string mark { get; set; }
        public string cancelledByMark { get; set; }
        public string authenticationCode { get; set; }
        public string vatNumber { get; set; }
        public string country { get; set; }
        public string branch { get; set; }
        public string CvatNumber { get; set; }
        public string Ccountry { get; set; }
        public string Cbranch { get; set; }
        public string series { get; set; }
        public string aa { get; set; }
        public string issueDate { get; set; }
        public string invoiceType { get; set; }
        public string currency { get; set; }
        public string movePurpose { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
        public string lineNumber { get; set; }
        public string quantity { get; set; }
        public string measurementUnit { get; set; }
        public string netValue { get; set; }
        public string vatCategory { get; set; }
        public string vatAmount { get; set; }
        public string deductionsAmount { get; set; }
        public string lineComments { get; set; }
        public string totalNetValue { get; set; }
        public string totalVatAmount { get; set; }
        public string totalWithheldAmount { get; set; }
        public string totalFeesAmount { get; set; }
        public string totalStampDutyAmount { get; set; }
        public string totalOtherTaxesAmount { get; set; }
        public string totalDeductionsAmount { get; set; }
        public string totalGrossValue { get; set; }
    }
}
