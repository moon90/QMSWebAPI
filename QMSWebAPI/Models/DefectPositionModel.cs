using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class DefectPositionModel
    {
       // public int SilhouteeGridId { get; set; }
        public int GridNo { get; set; }
        public int DefectPositionId { get; set; }
        public int FrontorBack { get; set; }
        public string DefectPositionName { get; set; }
        public List<DefectModel> DefectList { get; set; }
    }
}