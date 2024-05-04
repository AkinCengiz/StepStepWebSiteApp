using Microsoft.AspNetCore.Mvc;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.Business.Concrete;
using StepStepWebSiteApp.DataAccess.Concrete.EntityFramework;

namespace StepStepWebSiteApp.MVCPresenter.ViewComponents.Feature;

public class FeatureList : ViewComponent
{
    private readonly IFeatureService _featureService;

    public FeatureList(IFeatureService featureService)
    {
        _featureService = featureService;
    }


    public IViewComponentResult Invoke()
    {
        var feature = _featureService.GetAll();
        return View(feature);
    }
}
