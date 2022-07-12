using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "pro";
            if (type == "basic")
            {
                DocumentProgram documentProgram = new DocumentProgram();
                documentProgram.OpenDocument();
                documentProgram.EditDocument();
                documentProgram.SaveDocument();
            }
            else if (type == "pro")
            {
                ProDocumentProgram documentProgram = new ProDocumentProgram();
                documentProgram.OpenDocument();
                documentProgram.EditDocument();
                documentProgram.SaveDocument();
            }
            else if (type == "expert")
            {
                ExpertDocumentProgram documentProgram = new ExpertDocumentProgram();
                documentProgram.OpenDocument();
                documentProgram.EditDocument();
                documentProgram.SaveDocument();

            }
            else 
            {
                Console.WriteLine("keyword not found");

            }
        }
    }
}
