using System;

namespace DocumentManagerUI.ModelResponse
{
    public class PictureObjectResponse
    {
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureScale { get; set; }
        public string PictureTypeMime { get; set; }

        public PictureObjectResponse()
        {
        }

        public PictureObjectResponse(string name, byte[] picture,  string pictureTypeMime, byte[] pictureScale)
        {
            Name = name;
            Picture = picture;
            PictureTypeMime = pictureTypeMime;
            PictureScale = pictureScale;
        }
    }
}
