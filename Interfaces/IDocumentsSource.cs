using System.Collections.Generic;
using Domain;

namespace Interfaces
{
    public interface IDocumentsSource
    {
        List<Document> GetDocuments();
    }
}
