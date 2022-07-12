using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        public string account;
        public string customer;
        public string provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            this.account =  account;
            this.customer = customer;
            this.provider = provider;
        }

        public string CostCalculation(bool needEdv)
        {
            if (Article == "Laptop")
            {
                double costOfProduct = 0;
                if (needEdv)
                {
                    costOfProduct = (Quantity * 1400) + 1400 * 0.18;
                    
                }
                else
                {
                     costOfProduct = Quantity * 1400;
                }
                return $"Article:{Article}, Quantity:{Quantity}, Price:{1400}, costOfProduct:{costOfProduct}";
            }
            return string.Empty;
        }
    }
}
