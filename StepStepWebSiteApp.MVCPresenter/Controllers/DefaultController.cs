using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Concrete.Contexts;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.MVCPresenter.Controllers;
public class DefaultController : Controller
{ 
	private readonly IMessageService _messageService;

	public DefaultController(IMessageService messageService)
	{
		_messageService = messageService;
	}

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

    [HttpPost]
    public IActionResult SendMessage(Message message)
    {
	    
		_messageService.Add(message);
		return RedirectToAction("Index");
		
	}
}
