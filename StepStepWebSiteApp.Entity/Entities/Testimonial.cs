using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Testimonial : BaseModel
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string CompanyName { get; set; }
	public string Comment { get; set; }
	public string ImageUrl { get; set; }
}
