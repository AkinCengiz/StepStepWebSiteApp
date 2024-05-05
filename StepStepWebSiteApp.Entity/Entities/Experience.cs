using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Experience : BaseModel
{
	public string Title { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public string ImageUrl { get; set; }
	public string Description { get; set; }
	public string SubTitle { get; set; }
}
