using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class PositionListForAPI
    {
        public bool IsSuccess { get; set; }
        public string Messgae { get; set; }
        public List<DefectPositionModel> DefectPositions { get; set; }
    }
}