using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Invoice
    {
        private string account;
        private string customer;
        private string provider;

        public Invoice()
        {

        }
        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

            var Article = new Invoice(account, customer, provider);
            var Quantity = new Invoice(account, customer, provider);
        }

        public string Article { get; set; }
        public string Quantity { get; set; }

        static void CostCalculation()
        {
            bool needEdv = true;
            {
                Console.WriteLine("");
            }
        }


    }


}

   

    







