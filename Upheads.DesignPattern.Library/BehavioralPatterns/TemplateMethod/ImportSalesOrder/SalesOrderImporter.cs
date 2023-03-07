using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    public abstract class SalesOrderImporter
    {
        /// <summary>
        /// The template method
        /// </summary>
        public void Import(string path)
        {
            var file = OpenFile(path);
            var rawData = ExtraData(file);
            var saleOrder = AnalyzeData(rawData);
            Save(saleOrder);
            CloseFile(file);
        }

        public abstract ImportFile OpenFile(string path);
        public abstract RawData ExtraData(ImportFile file);
        public virtual SalesOrder AnalyzeData(RawData rawData)
        {
            var salesOrder = rawData.ToSalesOrder();
            Console.WriteLine($"Analyze the sale order {salesOrder.OrderNumer} - {salesOrder.Title}");
            return salesOrder;
        }

        public virtual void Save(SalesOrder salesOrder)
        {
            Console.WriteLine($"Saved the sale order {salesOrder.OrderNumer} - {salesOrder.Title}");
        }

        public abstract void CloseFile(ImportFile file);
    }
}
