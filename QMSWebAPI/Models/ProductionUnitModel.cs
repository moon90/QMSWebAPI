using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class ProductionUnitModel
    {
        public int QmsDetailsId { get; set; }
        public int? QmsMasterKey { get; set; }
        public int? DefectId { get; set; }
        public int? DefectPositionId { get; set; }
        public int? DefectQuantity { get; set; }
        public string GarmentsNo { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
    }
}