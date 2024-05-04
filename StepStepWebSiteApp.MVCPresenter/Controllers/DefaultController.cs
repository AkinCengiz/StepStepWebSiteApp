using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Concrete.Contexts;

namespace StepStepWebSiteApp.MVCPresenter.Controllers;
public class DefaultController : Controller
{
   public IActionResult Index()
	{
		return View();
	}

    public PartialViewResult HeadPartial()
    {
        return PartialView();
    }

    public PartialViewResult HeaderPartial()
    {
        return PartialView();
    }

    public PartialViewResult ScriptPartial()
    {
        return PartialView();
    }

}
