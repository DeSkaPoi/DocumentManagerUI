using System;

namespace DocumentManagerUI.ModelResponse
{
    public class FileObjectResponse
    {
        public string Name { get; set; }
        public byte[] File { get; set; }
        public string FileTypeMime { get; set; }

        public FileObjectResponse()
        {
        }

        public FileObjectResponse(string name, byte[] file, string fileTypeMime)
        {
            Name = name;
            File = file;
            FileTypeMime = fileTypeMime;
        }
    }
}
