using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Skill : BaseModel
{
	public string Title { get; set; }
	public byte Grade { get; set; }
}
