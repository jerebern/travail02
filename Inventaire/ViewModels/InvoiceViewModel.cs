using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using app_models;
using BillingManagement.Business;
using BillingManagement.Models;

namespace BillingManagement.UI.ViewModels
{
    class InvoiceViewModel : BaseViewModel
    {

        private ObservableCollection<Invoice> invoices;
        private Invoice selectedInvoice;


        public InvoiceViewModel(IEnumerable<Customer> customerData)
        {
            InvoicesDataService ids = new InvoicesDataService(customerData);
            Invoices = new ObservableCollection<Invoice>(ids.GetAll().ToList());
        }

        public ObservableCollection<Invoice> Invoices
        {

            get => invoices;

            private set
            {

                invoices = value;
                OnPropertyChanged();

            }

        }

        public Invoice SelectedInvoice
        {

            get => selectedInvoice;

            set
            {
                selectedInvoice = value;
                OnPropertyChanged();

            }

        }



    }
}
