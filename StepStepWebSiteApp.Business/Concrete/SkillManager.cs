using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class SkillManager : ISkillService
{
	private readonly ISkillDal _skillDal;

	public SkillManager(ISkillDal skillDal)
	{
		_skillDal = skillDal;
	}

	public void Add(Skill entity)
	{
		_skillDal.Add(entity);
	}

	public void Update(Skill entity)
	{
		_skillDal.Update(entity);
	}

	public void Delete(Skill entity)
	{
		_skillDal.Delete(entity);
	}

	public List<Skill> GetAll()
	{
		return _skillDal.GetAll();
	}

	public Skill GetById(int id)
	{
		return _skillDal.Get(s => s.Id == id);
	}
}
