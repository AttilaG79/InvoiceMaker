using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker
{
    class InvoiceDetails
    {
        public string Company { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }       
        public double Price { get; set; }
        public double VAT { get; set; }        
        public double PriceSum { get; set; }
        public double Quantity { get; set; }
        public DateTime Time { get; set; }

        public InvoiceDetails()
        {
            this.Time = DateTime.Now;
        }
    }
   
}
