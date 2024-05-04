using Microsoft.AspNetCore.Mvc;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.About;

public class AboutList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
