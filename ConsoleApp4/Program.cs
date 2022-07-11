using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentProgram document = new DocumentProgram();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();



        }

    }
}
