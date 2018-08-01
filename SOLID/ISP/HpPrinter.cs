using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.SOLID.ISP
{
    class HpPrinter : IPrintScanContent, IFaxContent
    {
        public void FaxContent(string content)
        {
            Console.WriteLine("FaxContent");
        }

        public void PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopyContent");
        }

        public void PrintContent(string content)
        {
            Console.WriteLine("PrintContent");
        }

        public void ScanContent(string content)
        {
            Console.WriteLine("ScanContent");
        }
    }
}
