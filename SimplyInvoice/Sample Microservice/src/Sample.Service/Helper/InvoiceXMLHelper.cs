using Sample.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Service.Helper
{
    public class InvoiceXMLHelper
    {
        private static readonly string InvoiceXML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
"<!-- Created with Liquid Technologies Online Tools 1.0 (https://www.liquid-technologies.com) -->" +
"<inv:InvoicesDoc xmlns=\"https://www.aade.gr/myDATA/incomeClassificaton/v1.0\" xmlns:ecls=\"https://www.aade.gr/myDATA/expensesClassificaton/v1.0\" xmlns:inv=\"http://www.aade.gr/myDATA/invoice/v1.0\" xsi:schemaLocation=\"http://www.aade.gr/myDATA/invoice/v1.0 schema.xsd\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
  "<inv:invoice>" +
    "<inv:uid>[uid>]</inv:uid>" +
    "<inv:mark>[mark]</inv:mark>" +
    "<inv:cancelledByMark>[cancelledByMark]</inv:cancelledByMark>" +
    "<inv:authenticationCode>[authenticationCode]</inv:authenticationCode>" +
    "<inv:issuer>" +
      "<inv:vatNumber>[vatNumber]</inv:vatNumber>" +
      "<inv:country>[country]</inv:country>" +
      "<inv:branch>[branch]</inv:branch>" +
    "</inv:issuer>" +

    "<inv:counterpart>" +
      "<inv:vatNumber>[CvatNumber]</inv:vatNumber>" +
      "<inv:country>[Ccountry]</inv:country>" +
      "<inv:branch>[Cbranch]</inv:branch>" +

    "</inv:counterpart>" +

    "<inv:invoiceHeader>" +
      "<inv:series>[series]</inv:series>" +
      "<inv:aa>[aa]</inv:aa>" +
      "<inv:issueDate>[issueDate]</inv:issueDate>" +
      "<inv:invoiceType>[invoiceType]</inv:invoiceType>" +
      "<inv:currency>[currency]</inv:currency>" +
      "<inv:movePurpose>[movePurpose]</inv:movePurpose>	" +
    "</inv:invoiceHeader>" +

    "<inv:paymentMethods>" +
      "<inv:paymentMethodDetails>" +
       " <inv:type>[type]</inv:type>" +
        "<inv:amount>[amount]</inv:amount>" +
      "</inv:paymentMethodDetails>" +

    "</inv:paymentMethods>" +

    "<inv:invoiceDetails>" +
      "<inv:lineNumber>[lineNumber]</inv:lineNumber>" +
      "<inv:quantity>[quantity]</inv:quantity>" +
      "<inv:measurementUnit>[measurementUnit]</inv:measurementUnit>" +
      "<inv:netValue>[netValue]</inv:netValue>" +
     " <inv:vatCategory>[vatCategory]</inv:vatCategory>" +
      "<inv:vatAmount>[vatAmount]</inv:vatAmount>" +

      "<inv:deductionsAmount>[deductionsAmount]</inv:deductionsAmount>" +
      "<inv:lineComments>[lineComments]</inv:lineComments>" +
   " </inv:invoiceDetails>" +



    "<inv:invoiceSummary>" +
      "<inv:totalNetValue>[totalNetValue]</inv:totalNetValue>" +
      "<inv:totalVatAmount>[totalVatAmount]</inv:totalVatAmount>" +
      "<inv:totalWithheldAmount>[totalWithheldAmount]</inv:totalWithheldAmount>" +
      "<inv:totalFeesAmount>[totalFeesAmount]</inv:totalFeesAmount>" +
      "<inv:totalStampDutyAmount>[totalStampDutyAmount]</inv:totalStampDutyAmount>" +
      "<inv:totalOtherTaxesAmount>[totalOtherTaxesAmount]</inv:totalOtherTaxesAmount>" +
      "<inv:totalDeductionsAmount>[totalDeductionsAmount]</inv:totalDeductionsAmount>" +
      "<inv:totalGrossValue>[totalGrossValue]</inv:totalGrossValue>" +

    "</inv:invoiceSummary>" +
  "</inv:invoice>" +
"</inv:InvoicesDoc>";

        public static string GetInvoiceXML(SendInvoiceEntity invData)
        {

            string Invoice = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
"<!-- Created with Liquid Technologies Online Tools 1.0 (https://www.liquid-technologies.com) -->" +
"<inv:InvoicesDoc xmlns=\"https://www.aade.gr/myDATA/incomeClassificaton/v1.0\" xmlns:ecls=\"https://www.aade.gr/myDATA/expensesClassificaton/v1.0\" xmlns:inv=\"http://www.aade.gr/myDATA/invoice/v1.0\" xsi:schemaLocation=\"http://www.aade.gr/myDATA/invoice/v1.0 schema.xsd\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
  "<inv:invoice>" +
    "<inv:uid>" + invData.uid + "</inv:uid>" +
    "<inv:mark>" + invData.mark + "</inv:mark>" +
    "<inv:cancelledByMark>" + invData.cancelledByMark + "</inv:cancelledByMark>" +
    "<inv:authenticationCode>" + invData.authenticationCode + "</inv:authenticationCode>" +
    "<inv:issuer>" +
      "<inv:vatNumber>" + invData.vatNumber + "</inv:vatNumber>" +
      "<inv:country>" + invData.country + "</inv:country>" +
      "<inv:branch>" + invData.branch + "</inv:branch>" +
    "</inv:issuer>" +

    "<inv:counterpart>" +
      "<inv:vatNumber>" + invData.CvatNumber + "</inv:vatNumber>" +
      "<inv:country>" + invData.Ccountry + "</inv:country>" +
      "<inv:branch>" + invData.Cbranch + "</inv:branch>" +

    "</inv:counterpart>" +

    "<inv:invoiceHeader>" +
      "<inv:series>" + invData.series + "</inv:series>" +
      "<inv:aa>" + invData.aa + "</inv:aa>" +
      "<inv:issueDate>" + invData.issueDate + "</inv:issueDate>" +
      "<inv:invoiceType>" + invData.invoiceType + "</inv:invoiceType>" +
      "<inv:currency>" + invData.currency + "</inv:currency>" +
      "<inv:movePurpose>" + invData.movePurpose + "</inv:movePurpose>	" +
    "</inv:invoiceHeader>" +

    "<inv:paymentMethods>" +
      "<inv:paymentMethodDetails>" +
       " <inv:type>" + invData.type + "</inv:type>" +
        "<inv:amount>" + invData.amount + "</inv:amount>" +
      "</inv:paymentMethodDetails>" +

    "</inv:paymentMethods>" +

    "<inv:invoiceDetails>" +
      "<inv:lineNumber>" + invData.lineNumber + "</inv:lineNumber>" +
      "<inv:quantity>" + invData.quantity + "</inv:quantity>" +
      "<inv:measurementUnit>" + invData.measurementUnit + "</inv:measurementUnit>" +
      "<inv:netValue>" + invData.netValue + "</inv:netValue>" +
     " <inv:vatCategory>" + invData.vatCategory + "</inv:vatCategory>" +
      "<inv:vatAmount>" + invData.vatAmount + "</inv:vatAmount>" +

      "<inv:deductionsAmount>" + invData.deductionsAmount + "</inv:deductionsAmount>" +
      "<inv:lineComments>" + invData.lineComments + "</inv:lineComments>" +
   " </inv:invoiceDetails>" +



    "<inv:invoiceSummary>" +
      "<inv:totalNetValue>" + invData.totalNetValue + "</inv:totalNetValue>" +
      "<inv:totalVatAmount>" + invData.totalVatAmount + "</inv:totalVatAmount>" +
      "<inv:totalWithheldAmount>" + invData.totalWithheldAmount + "</inv:totalWithheldAmount>" +
      "<inv:totalFeesAmount>" + invData.totalFeesAmount + "</inv:totalFeesAmount>" +
      "<inv:totalStampDutyAmount>" + invData.totalStampDutyAmount + "</inv:totalStampDutyAmount>" +
      "<inv:totalOtherTaxesAmount>" + invData.totalOtherTaxesAmount + "</inv:totalOtherTaxesAmount>" +
      "<inv:totalDeductionsAmount>" + invData.totalDeductionsAmount + "</inv:totalDeductionsAmount>" +
      "<inv:totalGrossValue>" + invData.totalGrossValue + "</inv:totalGrossValue>" +

    "</inv:invoiceSummary>" +
  "</inv:invoice>" +
"</inv:InvoicesDoc>";    

            return Invoice;
        }
    }

    
}
