using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    public abstract class SalesOrderImporter
    {
        /// <summary>
        /// The template method
        /// </summary>
        public void Import(string path)
        {
            //Open the file
            var file = OpenFile(path);

            //Read raw data in file
            var rawData = ExtraData(file);

            //Convert raw data to us data
            var saleOrder = AnalyzeData(rawData);

            //Save SO to us database
            Save(saleOrder);

            //Close the file
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
