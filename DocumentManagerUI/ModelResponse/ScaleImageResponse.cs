using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture.Infrastructure.DBModel
{
    public class ScaleImageResponse
    {
        public Guid Id { get; set; }
        public string ScaleImage { get; set; }

        public ScaleImageResponse(Guid id, string scaleImage)
        {
            Id = id;
            ScaleImage = scaleImage;
        }
    }
}
