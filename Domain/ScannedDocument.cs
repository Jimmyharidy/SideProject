using System.Collections.Generic;

namespace Domain
{
    public class ScannedDocument
    {
        public Document Document { get; set; }
        private Dictionary<string, object> Result { get; set; } 
    }
    
}
