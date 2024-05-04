using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Feature;

public class FeatureSocialAccountList : ViewComponent
{
	private readonly ISocialAccountService _socialAccountService;

	public FeatureSocialAccountList(ISocialAccountService socialAccountService)
	{
		_socialAccountService = socialAccountService;
	}

	public IViewComponentResult Invoke()
	{
		var socialAccounts = _socialAccountService.GetAll();
		return View(socialAccounts);
	}
}
