using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class SocialAccountManager : ISocialAccountService
{
	private readonly ISocialAccountDal _socialAccountDal;

	public SocialAccountManager(ISocialAccountDal socialAccountDal)
	{
		_socialAccountDal = socialAccountDal;
	}

	public void Add(SocialAccount entity)
	{
		_socialAccountDal.Add(entity);
	}

	public void Update(SocialAccount entity)
	{
		_socialAccountDal.Update(entity);
	}

	public void Delete(SocialAccount entity)
	{
		_socialAccountDal.Delete(entity);
	}

	public List<SocialAccount> GetAll()
	{
		return _socialAccountDal.GetAll();
	}

	public SocialAccount GetById(int id)
	{
		return _socialAccountDal.Get(s => s.Id == id);
	}
}
