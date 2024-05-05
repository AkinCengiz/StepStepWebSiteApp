using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Contact;

public class ContactList : ViewComponent
{
	private readonly IContactService _contactService;

	public ContactList(IContactService contactService)
	{
		_contactService = contactService;
	}

	public IViewComponentResult Invoke()
	{
		var contacts = _contactService.GetAll();
		return View(contacts);
	}
}
