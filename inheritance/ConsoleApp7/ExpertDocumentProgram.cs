using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
