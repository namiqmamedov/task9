using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("3213142", "eli", "huseyn");
            invoice.Article = "Laptop";
            invoice.Quantity = 3;

            Console.WriteLine(invoice.CostCalculation(false));
        }
    }
}
