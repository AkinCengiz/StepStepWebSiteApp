using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.About;

public class AboutList : ViewComponent
{
    private readonly IAboutService _aboutService;

    public AboutList(IAboutService aboutService)
    {
	    _aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var abouts = _aboutService.GetAll();
        return View(abouts);
    }
}
