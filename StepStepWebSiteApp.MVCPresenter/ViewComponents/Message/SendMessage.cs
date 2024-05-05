using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Message;

public class SendMessage : ViewComponent
{
	private readonly IMessageService _messageService;

	public SendMessage(IMessageService messageService)
	{
		_messageService = messageService;
	}

	public IViewComponentResult Invoke()
	{
		return View();
	}
}
