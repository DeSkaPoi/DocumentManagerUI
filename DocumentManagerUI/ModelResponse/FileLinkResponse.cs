using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentManagerUI.ModelResponse;

namespace ModelDomain
{
    public class FileLinkResponse
    {
        public Guid Id { get; set; }
        public Guid FileId { get; set; }
        public Document Document { get; set; }

       /* public FileLink(Guid FileId)
        {
            this.FileId = FileId;
        }*/
    }
}
