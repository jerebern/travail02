using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using BillingManagement.Business;
using BillingManagement.Models;

namespace BillingManagement.UI.ViewModels
{
    class InvoiceViewModel : BaseViewModel
    {

        readonly InvoicesDataService invoicesDataService = new InvoicesDataService();

        private ObservableCollection<Invoice> invoices;
        private Invoice selectedInvoice;

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

        public InvoiceViewModel()
        {

            InitValues();

        }

        private void InitValues()
        {
            Invoices = new ObservableCollection<Invoice>(invoicesDataService.GetAll());
            Debug.WriteLine(invoices.Count);
        }

    }
}
