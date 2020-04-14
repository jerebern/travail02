using app_models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.Models
{
    class Invoice
    {
        private static int InvoiceId = 0;
        private DateTime CreationDateTime;
        private Customer Customer;
        private Double SubTotal;
        private Double FedTax;
        private Double ProvTax;
        private Double Total;

        public Invoice(double SubTotalTMP) {
            InvoiceId++;
            CreationDateTime = DateTime.Now;
            ProvTax = 0.9975;
            FedTax = 0.05;
            SubTotal = SubTotalTMP;
            Total = (FedTax + ProvTax) * SubTotal;

        }

        public Invoice(Customer customerTMP)
        {
            Customer = customerTMP;
            InvoiceId++;
            CreationDateTime = DateTime.Now;
            ProvTax = 0.9975;
            FedTax = 0.05;
            SubTotal = SubTotalTMP;
            Total = (FedTax + ProvTax) * SubTotal;

        }

    }
}
