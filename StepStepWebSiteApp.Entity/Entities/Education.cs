using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Education : BaseModel
{
	public string SchoolName { get; set; }
	public string Department { get; set; }
	public string FieldOfStudy { get; set; }
	public string Degree { get; set; }
	public double GPA { get; set; }
	public string Description { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? EndDate { get; set; }
}
