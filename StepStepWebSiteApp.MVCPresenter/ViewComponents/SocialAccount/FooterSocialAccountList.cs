using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.SocialAccount;

public class FooterSocialAccountList : ViewComponent
{
	private readonly ISocialAccountService _socialAccountService;

	public FooterSocialAccountList(ISocialAccountService socialAccountService)
	{
		_socialAccountService = socialAccountService;
	}

	public IViewComponentResult Invoke()
	{
		var socialAccounts = _socialAccountService.GetAll();
		return View(socialAccounts);
	}
}
