using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class ExperienceManager : IExperienceService
{
	private readonly IExperienceDal _experienceDal;

	public ExperienceManager(IExperienceDal experienceDal)
	{
		_experienceDal = experienceDal;
	}

	public void Add(Experience entity)
	{
		_experienceDal.Add(entity);
	}

	public void Update(Experience entity)
	{
		_experienceDal.Update(entity);
	}

	public void Delete(Experience entity)
	{
		_experienceDal.Delete(entity);
	}

	public List<Experience> GetAll()
	{
		return _experienceDal.GetAll();
	}

	public Experience GetById(int id)
	{
		return _experienceDal.Get(e => e.Id == id);
	}
}
