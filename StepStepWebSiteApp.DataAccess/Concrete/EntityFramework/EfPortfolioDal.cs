using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.DataAccess.Concrete.Contexts;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.DataAccess.Concrete.EntityFramework;
public class EfPortfolioDal : EfGenericRepository<Portfolio,StepStepWebSiteContext>,IPortfolioDal
{
}
