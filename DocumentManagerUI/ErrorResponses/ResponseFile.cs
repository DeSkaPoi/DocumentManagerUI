using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DocumentManager.API.ResponseFile
{
    public class ResponseFile
    {
        public string ObjectId { get; }
        public byte[] Content { get; }

        public ResponseFile(string objectId, byte[] content)
        {
            ObjectId = objectId;
            Content = content;
        }
    }
}
