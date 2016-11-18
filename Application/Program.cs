using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Program
    {
        private static DocumentProcess documentProcess;

        static void Main(string[] args)
        {
            documentProcess = new DocumentProcess();

            var documents = documentProcess.DocumentsSource.GetDocuments();
            var words = documentProcess.WordsSource.GetWords();
            var scannedDocuments = documentProcess.DocumentScanner.Scan(documents, words);
            documentProcess.DatabaseStorage.Store(scannedDocuments);
        }
    }
}
