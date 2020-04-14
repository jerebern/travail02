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

        public Invoice() {
            InvoiceId++;
            CreationDateTime = DateTime.Now;
            ProvTax = 0.9975;
            FedTax = 0.05;
            SubTotal = 0;
            ProvTax = 0;
            Total = 0;

        }

        public Invoice(Customer customerTMP)
        {
            InvoiceId++;
            CreationDateTime = DateTime.Now;
            ProvTax = 0.9975;
            FedTax = 0.05;
            SubTotal = 0;
            ProvTax = 0;
            Total = 0;

        }

    }
}
