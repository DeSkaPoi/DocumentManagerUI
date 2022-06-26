using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ModelDomain;

namespace DocumentManagerUI.ModelResponse
{
    public class Document
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long (>25).")]
        public string Title { get; set; }
        [StringLength(50, ErrorMessage = "Name is too long (>50).")]
        public string Content { get; set; } 
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<FileLinkResponse> Files { get; set; } 
        public List<PictureLink> Pictures { get; set; } 
        public List<VideoLink> Videos { get; set; } 
    }
}
