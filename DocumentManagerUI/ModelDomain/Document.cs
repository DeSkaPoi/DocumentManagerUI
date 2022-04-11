using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ModelDomain
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

        public List<FileLink> Files { get; set; } 
        public List<PictureLink> Pictures { get; set; } 
        public List<VideoLink> Videos { get; set; } 
        
        public Document(Guid id, string title, string content, string description, DateTime creationTime, DateTime lastUpdate,
            List<FileLink> files, List<PictureLink> pictures, List<VideoLink> videos)
        {
            Id = id;
            Title = title;
            Content = content;
            Description = description;
            CreationTime = creationTime;
            LastUpdate = lastUpdate;
            Files = files;
            Pictures = pictures;
            Videos = videos;
        }
        

    }
}
