using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentManagerUI.ModelResponse
{
    public class PictureResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
        public string Size { get; set; }
        public string ResolutionX { get; set; }
        public string ResolutionY { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpDate { get; set; }
        public PictureObjectResponse PictureObject { get; set; }
        
        public PictureResponse() { }

        public PictureResponse(PictureObjectResponse response)
        {
            PictureObject = response;
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
