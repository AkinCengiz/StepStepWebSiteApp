using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Contact : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
