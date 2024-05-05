using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Skill;

public class SkillList : ViewComponent
{
    private readonly ISkillService _skillService;

    public SkillList(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public IViewComponentResult Invoke()
    {
        var skills = _skillService.GetAll();
        return View(skills);
    }
}
