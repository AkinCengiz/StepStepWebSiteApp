using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStepWebSiteApp.Entity.Abstract;
public abstract class BaseModel : IEntity
{
	public int Id { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
	public bool IsActive { get; set; } = true;
	public bool IsDeleted { get; set; } = false;
}
