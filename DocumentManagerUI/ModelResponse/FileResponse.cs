using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentManagerUI.ModelResponse
{
    public class FileResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
        public string KeyWords { get; set; }
        public string Description { get; set; }
        [Range(typeof(int), "0", "2147483647", ErrorMessage = "The value {0} must be a positive number.")]
        public int? ContentType { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpDate { get; set; }
        public string Size { get; set; }
        public FileObjectResponse FileObject { get; set; }
        
        public FileResponse() { }

        public FileResponse(FileObjectResponse response)
        {
            FileObject = response;
        }

        /*public FileInfoResponse(Guid id, string title, string format, string keyWords, string description, int? contentType,
            string content, DateTime creationTime, DateTime lastUpDate, string size, FileObjectResponse fileObj)
        {
            Id = id;
            Title = title;
            Format = format;
            KeyWords = keyWords;
            Description = description;
            ContentType = contentType;
            Content = content;
            CreationTime = creationTime;
            LastUpDate = lastUpDate;
            Size = size;
            FileObj = fileObj;
        }*/
    }
}
