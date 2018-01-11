using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using TechMVCDatabase.Models;

namespace TechMVCDatabase.Controllers
{
    public class FileUploadController : Controller
    {
        //TechMVCDatabaseEntities1 db = new TechMVCDatabaseEntities1();
        TechMVCDatabaseEntities db = new TechMVCDatabaseEntities();
        public ActionResult FileUpload()
        {
            
            return Redirect("CreatRecord");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult FileUpload(HttpPostedFileBase uploadfile)
        {
            var ImgList = new List<string>();
            //var techdata = from t in db.TechDetails select t;
               


            if (uploadfile.ContentLength > 0)
            {
              

            }
            return Redirect("CreatRecord");
        }
    }
}