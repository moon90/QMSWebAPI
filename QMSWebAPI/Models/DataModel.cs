using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QMSWebAPI.Models
{
    public class QMSDataModel
    {
        public int batchQty { get;set;}
        public string buyerName { get;set;}
        public string color { get;set;}
        public string date { get;set;}
        public string defectPos { get;set;}
        public string garmentNo { get;set;}
        public string garmentPos { get;set;}
        public string line { get;set;}
        public string lotNo { get;set;}
        public string po { get;set;}
        public string size { get;set;}
        public string styleCat { get;set;}
        public string styleSubCat { get;set;}
        public string smv { get;set;}
        public string time { get;set;}
        public string uid_code { get;set;}
        public string unit { get;set;}
        public string defectCount { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string defect { get; set; }
    }
}