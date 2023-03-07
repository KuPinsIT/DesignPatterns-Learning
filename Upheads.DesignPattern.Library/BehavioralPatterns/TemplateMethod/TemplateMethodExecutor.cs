using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod
{
    public class TemplateMethodExecutor : PatternExecutor
    {
        public override string Name => "Template Method - Behavioral Pattern";

        public override void Execute()
        {
            ConsoleExtension.WriteSeparator("Import sales order example");

            var xmlImporter = new XmlSalesOrderImporter();
            xmlImporter.Import("/Imports/Xml_SalersOrder.xml");

            Console.WriteLine();

            var pdfImporter = new PdfSalesOrderImporter();

            pdfImporter.Import("/Imports/Pdf_SalersOrder.xml");
        }
    }
}
