using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ProDocumentProgram : DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
