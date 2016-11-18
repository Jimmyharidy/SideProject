using System.Collections.Generic;
using Domain;

namespace Interfaces
{
    public interface IDatabaseStorage
    {
        bool Store(List<ScannedDocument> documents);
    }
}
