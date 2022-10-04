using System;

namespace DocumentManagerUI.ModelResponse
{
    public class PictureObjectResponse
    {
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public string FileTypeMime { get; set; }

        public PictureObjectResponse()
        {
        }

        public PictureObjectResponse(string name, byte[] picture,  string fileTypeMime)
        {
            Name = name;
            Picture = picture;
            FileTypeMime = fileTypeMime;
        }
    }
}
