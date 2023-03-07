using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    internal class PdfSalesOrderImporter : SalesOrderImporter
    {
        public override ImportFile OpenFile(string path)
        {
            Console.WriteLine($"Opened pdf file with path is {path}");
            return new ImportFile();
        }

        public override RawData ExtraData(ImportFile file)
        {
            Console.WriteLine($"Extra pdf file.");
            return new PdfData();
        }

        public override void CloseFile(ImportFile file)
        {
            Console.WriteLine($"Closed pdf file.");
        }
    }
}
