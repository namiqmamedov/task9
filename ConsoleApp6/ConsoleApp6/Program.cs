using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentProgram document = new DocumentProgram();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            ProDocumentProgram document1 = new ProDocumentProgram();
            document1.OpenDocument();
            document1.EditDocument();
            document1.SaveDocument();

            ExpertDocumentProgram document2 = new ExpertDocumentProgram();
            document2.OpenDocument();
            document2.EditDocument();
            document2.SaveDocument();

        }

    }
    
}



