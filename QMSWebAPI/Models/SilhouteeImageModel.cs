using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class SilhouteeImageModel
    {
        public int SilhouetteImageId { get; set; }
        public string SilhouetteImageName { get; set; }
        public string SilhouetteImageDirectory { get; set; }
        public string ServerFileName { get; set; }
        public int FrontBack { get; set; }
    }
}