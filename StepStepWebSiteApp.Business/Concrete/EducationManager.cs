using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class EducationManager : IEducationService
{
	private readonly IEducationDal _educationDal;

	public EducationManager(IEducationDal educationDal)
	{
		_educationDal = educationDal;
	}

	public void Add(Education entity)
	{
		_educationDal.Add(entity);
	}

	public void Update(Education entity)
	{
		_educationDal.Update(entity);
	}

	public void Delete(Education entity)
	{
		_educationDal.Delete(entity);
	}

	public List<Education> GetAll()
	{
		return _educationDal.GetAll();
	}

	public Education GetById(int id)
	{
		return _educationDal.Get(e => e.Id == id);
	}
}
