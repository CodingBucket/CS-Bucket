using System;
using System.Collections.Generic;
using System.Text;

// Interface Segregation Principal: Many client specific interface are better than one general purpose interface.

namespace Demo.SOLID.InterfaceSegregation
{
    interface IPrintScanContent
    {
        void PrintContent(string content);
        void ScanContent(string content);
        void PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        void FaxContent(string content);
    }

    interface IPrintDuplex
    {
        void PrintDuplexContent(string content);
    }
}
