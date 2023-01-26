using Inheritance;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ClassConstruction
{
    public class Inheritance
    {
        static void Main()
        {
        starter: Console.WriteLine("Enter the word:");
            var keyword = Console.ReadLine();

         switch (keyword.ToLower())
            {
                case "basic":
                    var documentProgram = new DocumentProgram();    
                    documentProgram.OpenDocument();
                    documentProgram.EditDocument();
                    documentProgram.SaveDocument();
                    break;
                case "pro":
                    var proDocumentProgram = new ProDocumentProgram();  
                    proDocumentProgram.OpenDocument();  
                    proDocumentProgram.EditDocument();  
                    proDocumentProgram.SaveDocument();  
                    break;
                case "expert":
                    var expertDocumentProgram = new ExpertDocumentProgram();    
                    expertDocumentProgram.OpenDocument();
                        expertDocumentProgram.EditDocument();
                    expertDocumentProgram.SaveDocument();
                    break;
                default:
                    goto starter;
            }


           

        }
    }
}
