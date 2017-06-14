using System.Net;
using System.Web.Mvc;
using OnlineStore.DAL;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class StoreFrontController : Controller
    {

        private MvcAffableBeanContext db = new MvcAffableBeanContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}