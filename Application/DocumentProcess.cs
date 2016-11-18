using Interfaces;

namespace Application
{
    public class DocumentProcess
    {
        public IDocumentsSource DocumentsSource { get; set; }
        public IWordsSource WordsSource { get; set; }
        public IDocumentScanner DocumentScanner { get; set; }
        public IDatabaseStorage DatabaseStorage { get; set; }

        public DocumentProcess()
        {
          
        }
    }
}
