using app_models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BillingManagement.Models
{
    public class Invoice : INotifyPropertyChanged
    {
        static int nextId;

        public int InvoiceId { get;
            private set; }

        public DateTime CreationDateTime { get; 
            private set; }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }

        private double subTotal;

        public double SubTotal
        {
            get { return subTotal; }
            set
            {
                subTotal = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ProvTax));
                OnPropertyChanged(nameof(FedTax));
                OnPropertyChanged(nameof(Total));
            }
        }

        public double FedTax => SubTotal * 0.05;
        public double ProvTax => SubTotal * 0.09975;

        public double Total => SubTotal + FedTax + ProvTax;

        public string Info => $"{CreationDateTime} : {Total}";

        public Invoice()
        {
            CreationDateTime = DateTime.Now;
            InvoiceId = Interlocked.Increment(ref nextId);

        }

        public Invoice(Customer customer)
        {

            Customer = customer;
            CreationDateTime = DateTime.Now;
            InvoiceId = Interlocked.Increment(ref nextId);
                      
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
