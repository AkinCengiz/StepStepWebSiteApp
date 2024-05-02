using StepStepWebSiteApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStepWebSiteApp.Entity.Entities;
public class Message : BaseModel
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public bool IsRead { get; set; } = false;
}
