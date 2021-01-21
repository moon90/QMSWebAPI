using Newtonsoft.Json.Linq;
using QMSWebAPI.DAL;
using QMSWebAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace QMSWebAPI.Controllers
{
    [RoutePrefix("api/{Controller}")]
    public class BasicQMSDataController : ApiController
    {
        BasicQMSDAL basicDal = new BasicQMSDAL();

        [HttpGet]
        public IHttpActionResult GetBarcodeInformation(int BusinessUnit,string BarcodeNumber)
        {
            return Json(basicDal.GetBarcodeInformation(BusinessUnit,BarcodeNumber));
        }

        [HttpPost]
        public IHttpActionResult SaveDataToQmsTable(JArray qMSDataModels)
        {
            return Json(basicDal.QmsDataSaveToDatabase(qMSDataModels.ToString()));
        }

        [HttpPost]
        public IHttpActionResult SaveToQmsMasterTable(int UserId, int MasterGenarationId, string TabId,float OperationSMV)
        {
            return Json(basicDal.SaveToQmsMasterTable(UserId,MasterGenarationId,TabId,OperationSMV));
        }

        [HttpPost]
        public IHttpActionResult QmsDefectEntryDetails(JObject qmsDetailsData)
        {
            return Json(basicDal.SaveDetailsToQms(qmsDetailsData));
        }

        [HttpPost]
        public IHttpActionResult DeleteQmsDataDetais(JObject qmsDetailsData)
        {
            return Json(basicDal.DeleteQmsDetailsData(qmsDetailsData));
        }

        [HttpPost]
        public IHttpActionResult DeleteDataQMS(JArray dataList)
        {
            return Json(basicDal.DeleteDataFromQms(dataList.ToString()));
        }

        [HttpGet]
        public IHttpActionResult RetriveDataForReport(string StartDate, string EndDate)
        {
            return Json(basicDal.RetriveDataForReport(StartDate, EndDate));
        }
        
        [HttpGet]
        public IHttpActionResult CheckoginQms(string UserName, string UserPassword)
        {
            return Json(basicDal.CheckLogingQms(UserName, UserPassword));
        }
        [HttpGet]
        public IHttpActionResult PositionGridListAPI(int StyleId,int Status)
        {
            SilhouteeModel silhouteeModel = basicDal.APIGetGridList(StyleId, Status);
            silhouteeModel.BaseServerPath= System.Web.Hosting.HostingEnvironment.MapPath("~/StyleUpload");
            return Json(silhouteeModel);
        }

        [HttpGet]
        public IHttpActionResult DefectListByPositionAPI(int StyleId, int Status)
        {
            List<DefectPositionModel> defectPositionModels = basicDal.PositionBasedDefectList(StyleId, Status);
            PositionListForAPI position = new PositionListForAPI();
            if (defectPositionModels.Count < 1)
            {
                position.IsSuccess = false;
                position.Messgae = "No Defect Position Found";
            }
            else
            {
                position.IsSuccess = true;
                position.Messgae = defectPositionModels.Count+ "Defect Position Found";
                position.DefectPositions = defectPositionModels;
            }
            return Json(position);
        }
        [HttpGet]
        public IHttpActionResult GetAllCommonData(int status)
        {
            return Json(basicDal.AllCommonModel(status));
        }

        //[HttpGet]
        //public FileCo GetDownloadFile(string DownloadableFIle)
        //{
        //    Byte[] b;
        //    b = System.IO.File.ReadAllBytes(DownloadableFIle);
        //    return File(b, "image/jpeg"); 
        //}
    }
}
