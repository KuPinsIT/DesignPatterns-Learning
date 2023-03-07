using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    public class SalesOrder
    {
        public string OrderNumer { get; set; }
        public string Title { get; set; }

        public SalesOrder(string orderNumber, string title)
        {
            OrderNumer = orderNumber;
            Title = title;
        }
    }
}
