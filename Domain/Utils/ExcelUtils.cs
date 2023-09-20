using SpcConverter.Domain.Models.ExcelModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Utils
{
    internal class ExcelUtils : IDisposable
    {
        public InputDocument ReadDocument(string path)
        {
            return null;
        }

        public InputDocument ConcatenateDocuments(IEnumerable<InputDocument> inputDocuments)
        {
            return null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
