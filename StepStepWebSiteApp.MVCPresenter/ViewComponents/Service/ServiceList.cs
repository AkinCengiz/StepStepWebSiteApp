using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Service;

public class ServiceList : ViewComponent
{
	private readonly IServiceService _serviceService;

	public ServiceList(IServiceService serviceService)
	{
		_serviceService = serviceService;
	}

	public IViewComponentResult Invoke()
	{
		var services = _serviceService.GetAll();
		return View(services);
	}
}
