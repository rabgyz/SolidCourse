﻿using System;
namespace SingleResponsibility
{
	public class InvoicePersistence
	{
        private Invoice _invoice;

        public InvoicePersistence(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SaveToPdf()
        {
            Console.WriteLine("Saving to pdf");
        }
    }
}

