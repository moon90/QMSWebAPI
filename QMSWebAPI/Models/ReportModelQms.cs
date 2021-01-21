using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class ReportModelQms
    {
        public int QmsDataID { get; set; }
        public string BusinessUnit { get; set; }
        public string LineNumber { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string BatchQty { get; set; }
        public string BuyerName { get; set; }
        public string ProductType { get; set; }
        public string StyleSubCat { get; set; }
        public string PoNumber { get; set; }
        public string GarmentsNumber { get; set; }
        public string DefectName { get; set; }
        public string DefectCount { get; set; }
        public string Color { get; set; }
        public string DefectPos { get; set; }
        public string SMV { get; set; }
        public string Size { get; set; }
        public string TabId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string StyleCat { get; set; }
        public string DefectID { get; set; }
        public string OperatorId { get; set; }
        public string MachineId { get; set; }
        public string UserID { get; set; }
        public string ModuleName { get; set; }
    }
}