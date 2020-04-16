﻿using app_models;
using BillingManagement.Models;
using System;
using System.Collections.Generic;


namespace BillingManagement.Business
{
    public class InvoicesDataService : IDataService<Invoice>
    {
        List<Invoice> invoices;
        IEnumerable<Customer> _customers;

        public InvoicesDataService(IEnumerable<Customer> customers)
        {
            _customers = customers;
            invoices = new List<Invoice>();
            

            initValues();
        }

        private void initValues()
        {
            Random rnd = new Random();


            foreach (var customer in _customers)
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
            foreach (var item in invoices)
            {
                yield return item;
            }

        }
    }
}
