using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace razecsystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : razecsystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}