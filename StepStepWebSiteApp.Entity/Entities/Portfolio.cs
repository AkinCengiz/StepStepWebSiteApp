﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Entity.Entities;
public class Portfolio : BaseModel
{
	public string Title { get; set; }
	public string Name { get; set; }
	public string ImageUrl { get; set; }
	public string ImageUrl2 { get; set; }
}
