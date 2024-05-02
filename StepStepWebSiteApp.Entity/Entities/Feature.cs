using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Feature : BaseModel
{
	public string Header { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Title { get; set; }
}
