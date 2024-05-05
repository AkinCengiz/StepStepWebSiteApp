using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Portfolio;

public class PortfolioList : ViewComponent
{
	private readonly IPortfolioService _portfolioService;

	public PortfolioList(IPortfolioService portfolioService)
	{
		_portfolioService = portfolioService;
	}

	public IViewComponentResult Invoke()
	{
		var portfolio = _portfolioService.GetAll();
		return View(portfolio);
	}
}
