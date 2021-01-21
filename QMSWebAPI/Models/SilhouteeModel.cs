using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class SilhouteeModel
    {
        public int StyleId { get; set; }
        public string StyleName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int SilhouetteId { get; set; }
        public string SilhouetteName { get; set; }
        public string BaseServerPath { get; set; }
        

        public List<SilhouteeImageModel> ImageList { get; set; }
        public List<DefectPositionModel> SilhouetteGridList { get; set; }
    }
}