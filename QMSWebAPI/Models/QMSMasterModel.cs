using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class QMSMasterModel
    {
        public int ProductionUnitId { get; set; }
        public int? QmsMasterKey { get; set; }
        public List<ProductionUnitModel> QmsDetailsInformation { get; set; }
    }
}