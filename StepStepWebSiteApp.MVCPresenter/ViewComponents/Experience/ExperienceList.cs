using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Experience;

public class ExperienceList : ViewComponent
{
	private readonly IExperienceService _experienceService;

	public ExperienceList(IExperienceService experienceService)
	{
		_experienceService = experienceService;
	}

	public IViewComponentResult Invoke()
	{
		var experiences = _experienceService.GetAll();
		return View(experiences);
	}
}
