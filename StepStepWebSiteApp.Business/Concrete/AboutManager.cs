using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class AboutManager : IAboutService
{
	private readonly IAboutDal _aboutDal;

	public AboutManager(IAboutDal aboutDal)
	{
		_aboutDal = aboutDal;
	}

	public void Add(About entity)
	{
		_aboutDal.Add(entity);
	}

	public void Update(About entity)
	{
		_aboutDal.Update(entity);
	}

	public void Delete(About entity)
	{
		_aboutDal.Delete(entity);
	}

	public List<About> GetAll()
	{
		return _aboutDal.GetAll();
	}

	public About GetById(int id)
	{
		return _aboutDal.Get(x => x.Id == id);
	}
}
