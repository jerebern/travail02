using app_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BillingManagement.Models
{
    public class Invoice : INotifyPropertyChanged
    {
        private static int invoidIdIndex;
        private int invoiceId = 0;
        private DateTime creationDateTime; 
        private Customer customer;
        private Double subTotal;
        private Double fedTax;
        private Double provTax;
        private Double total;

        public Invoice() {
            invoiceId = invoidIdIndex++;
            creationDateTime = DateTime.Now;
            

        }

        public Invoice(Customer customerTMP)
        {
            customer = customerTMP;
            invoiceId = invoidIdIndex++;
            creationDateTime = DateTime.Now;
            

        }


        public double Total()
        {

            total = provTax + fedTax + subTotal;

            return total;

        }

        public Double Subtotal
        {

            get => Subtotal ;

            set
            {
                subTotal = value;
                FedTax();
                ProvTax();

            }


        }

        public double FedTax ()
        {
            
            provTax = 0.05 * subTotal;

            return provTax;
          }
        
        public double ProvTax ()
        {

            fedTax = 0.09975 * subTotal;

            return fedTax;
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
