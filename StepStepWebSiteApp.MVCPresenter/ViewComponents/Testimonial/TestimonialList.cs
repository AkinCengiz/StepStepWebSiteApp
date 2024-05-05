using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Testimonial;

public class TestimonialList : ViewComponent
{
	private readonly ITestimonialService _testimonialService;

	public TestimonialList(ITestimonialService testimonialService)
	{
		_testimonialService = testimonialService;
	}

	public IViewComponentResult Invoke()
	{
		var testimonials = _testimonialService.GetAll();
		return View(testimonials);
	}
}
