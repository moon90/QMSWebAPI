namespace QMSWebAPI.Models
{
    public class BarcodeGenarateModal
    {
        public int StyleID { get; set; }
        public int MasterBarcodeId { get; set; }
        public int BundleNo { get; set; }
        public bool Status { get; set; }
        public string StyleName { get; set; }
        public string BusinessUnitName { get; set; }
        public string BarcodeNumber { get; set; }
        public int BuyerID { get; set; }
        public string BuyerName { get; set; }
        public int BusinessUnitId { get; set; }
        public string SelectDate { get; set; }
        public string PONumber { get; set; }
        public string BundleSize { get; set; }
        public string Color { get; set; }
        public int BatchQuantity { get; set; }
        public int CutNo { get; set; }
        public int ShadeNO { get; set; }
        public string ProductName { get; set; }
        public int NoOfBundle { get; set; }
        public string OperationSMV { get; set; }
        public string MachineId { get; set; }
        public string LotNo { get; set; }
    }
}