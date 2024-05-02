using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class PortfolioManager : IPortfolioService
{
	private readonly IPortfolioDal _portfolioDal;

	public PortfolioManager(IPortfolioDal portfolioDal)
	{
		_portfolioDal = portfolioDal;
	}

	public void Add(Portfolio entity)
	{
		_portfolioDal.Add(entity);
	}

	public void Update(Portfolio entity)
	{
		_portfolioDal.Update(entity);
	}

	public void Delete(Portfolio entity)
	{
		_portfolioDal.Delete(entity);
	}

	public List<Portfolio> GetAll()
	{
		return _portfolioDal.GetAll();
	}

	public Portfolio GetById(int id)
	{
		return _portfolioDal.Get(p => p.Id == id);
	}
}
