using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.TemplateMethod.ImportSalesOrder
{
    internal class XmlSalesOrderImporter : SalesOrderImporter
    {
        public override ImportFile OpenFile(string path)
        {
            Console.WriteLine($"Opened xml file with path is {path}");
            return new ImportFile();
        }

        public override RawData ExtraData(ImportFile file)
        {
            Console.WriteLine($"Extra xml file.");
            return new XmlData();
        }

        public override void CloseFile(ImportFile file)
        {
            Console.WriteLine($"Closed xml file.");
        }
    }
}
