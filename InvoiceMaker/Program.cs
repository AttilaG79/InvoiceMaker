using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceDetails invoice = new InvoiceDetails();

            Console.WriteLine("Please give your company details (name,address) :");
            invoice.Company = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please give a Product name :");
            invoice.ProductName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Description of the product :");
            invoice.ProductDescription = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please give the Price :");
            invoice.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the percentage value of your tax");
            invoice.VAT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the Quantity number :");
            invoice.Quantity = Convert.ToInt32(Console.ReadLine());

            invoice.PriceSum = (invoice.Price+invoice.Price * invoice.VAT / 100) * invoice.Quantity;

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine(" Customer details : {0}", invoice.Company);
            Console.WriteLine(" ");
            Console.WriteLine(" Summary of your invoice details : ");
            Console.WriteLine(" ");
            Console.WriteLine(" Product name : {0}", invoice.ProductName);
            Console.WriteLine(" Description : {0}", invoice.ProductDescription);
            Console.WriteLine(" Quantity : {0}", invoice.Quantity);
            Console.WriteLine(" Price :  £ {0}", invoice.Price);
            Console.WriteLine(" VAT   :   {0}", invoice.VAT);
            Console.WriteLine(" Total pay : £ {0}", invoice.PriceSum);
            Console.WriteLine(" This invoice made : {0}", invoice.Time);

            

            Console.ReadLine();

        }
    

    }
}
