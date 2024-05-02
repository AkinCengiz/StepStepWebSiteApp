using StepStepWebSiteApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStepWebSiteApp.Entity.Entities;
public class SocialAccount : BaseModel
{
    public string Platform { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
}
