using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelDomain
{
    public class Document
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Title { get; set; }
        public string Content { get; set; } 
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<FileLink> Files { get; set; } 
        public List<PictureLink> Pictures { get; set; } 
        public List<VideoLink> Videos { get; set; } 
        
        /*public Document()
        {
            Files = new List<FileLink>();
            Pictures = new List<PictureLink>();
            Videos = new List<VideoLink>();
        }
        */

    }
}
