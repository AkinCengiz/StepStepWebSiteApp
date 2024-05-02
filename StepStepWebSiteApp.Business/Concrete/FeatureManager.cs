using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class FeatureManager : IFeatureService
{
	private readonly IFeatureDal _featureDal;

	public FeatureManager(IFeatureDal featureDal)
	{
		_featureDal = featureDal;
	}

	public void Add(Feature entity)
	{
		_featureDal.Add(entity);
	}

	public void Update(Feature entity)
	{
		_featureDal.Update(entity);
	}

	public void Delete(Feature entity)
	{
		_featureDal.Delete(entity);
	}

	public List<Feature> GetAll()
	{
		return _featureDal.GetAll();
	}

	public Feature GetById(int id)
	{
		return _featureDal.Get(f => f.Id == id);
	}
}
