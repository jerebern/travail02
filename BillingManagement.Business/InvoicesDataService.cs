using BillingManagement.Models;
using System;
using System.Collections.Generic;


namespace BillingManagement.Business
{
    class InvoicesDataService : IDataService<Invoice>
    {

        readonly List<Invoice> invoices;

        public InvoicesDataService()
        {
            invoices = new List<Invoice>()
            {
                new Invoice() {Subtotal = 100}

            };

        }
            private void initValues()
            {
                Random rnd = new Random();


                foreach (var customer in _customers.GetAll())
                {
                    int nbInvoices = rnd.Next(10);

                    for (int i = 0; i < nbInvoices; i++)
                    {
                        var invoice = new Invoice(customer);
                        invoice.SubTotal = rnd.NextDouble() * 100 + 50;
                        customer.Invoices.Add(invoice);
                        invoices.Add(invoice);
                    }
                }
            }
        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

