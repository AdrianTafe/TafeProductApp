﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
        private double totalCharge;
        private double totalWrapCharge;
        private double gstCharge;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public double TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public double TotalWrapCharge
        {
            get { return totalWrapCharge; }
            set { totalWrapCharge = value; }
        }

        public double GSTCharge
        {
            get { return gstCharge; }
            set { gstCharge = value; }
        }

        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }

        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total charge
        public void calTotalCharge()
        {
            TotalCharge  = (double)totalPayment + 25;
        }

        //Calculate the total charge with wrap
        public void calTotalWrapCharge()
        {
            TotalWrapCharge = TotalCharge + 5;
        }

        //Calculate the total GST Charge
        public void calGSTCharge()
        {
            GSTCharge = TotalWrapCharge * 1.1;
        }
    }
}
