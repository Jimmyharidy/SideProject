using System.Collections.Generic;
using Domain;

namespace Interfaces
{
    public interface IDocumentScanner
    {
        List<ScannedDocument> Scan(List<Document> documents, List<string> words);
    }
}
