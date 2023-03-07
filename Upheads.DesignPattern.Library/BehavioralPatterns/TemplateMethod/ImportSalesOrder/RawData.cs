using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    public abstract class RawData
    {
        public abstract SalesOrder ToSalesOrder();
    }

    public class XmlData : RawData
    {
        public override SalesOrder ToSalesOrder()
        {
            return new SalesOrder("0001", "Xml SalesOrder");
        }
    }

    public class PdfData : RawData
    {
        public override SalesOrder ToSalesOrder()
        {
            return new SalesOrder("0002", "Pdf SalesOrder");
        }
    }
}
