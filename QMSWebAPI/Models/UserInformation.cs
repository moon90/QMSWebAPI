using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class UserInformation
    {
        public int QmsUserId { get; set; }
        public bool IsSuccessful  { get; set; }
        public string Message  { get; set; }
        public string BusinessUnit { get; set; }
        public int BusinessUnitId { get; set; }
        public string ProductionUnit { get; set; }
        public int ProductionUnitId { get; set; }
        public string ModuleName { get; set; }
        public string LineNumber { get; set; }
        public string UserName { get; set; }
    }
}