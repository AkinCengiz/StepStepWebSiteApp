using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class ServiceManager : IServiceService
{
	private readonly IServiceDal _serviceDal;

	public ServiceManager(IServiceDal serviceDal)
	{
		_serviceDal = serviceDal;
	}

	public void Add(Service entity)
	{
		_serviceDal.Add(entity);
	}

	public void Update(Service entity)
	{
		_serviceDal.Update(entity);
	}

	public void Delete(Service entity)
	{
		_serviceDal.Delete(entity);
	}

	public List<Service> GetAll()
	{
		return _serviceDal.GetAll();
	}

	public Service GetById(int id)
	{
		return _serviceDal.Get(s => s.Id == id);
	}
}
