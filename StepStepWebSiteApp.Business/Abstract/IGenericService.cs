using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Abstract;

namespace StepStepWebSiteApp.Business.Abstract;
public interface IGenericService<T> where T : class,IEntity,new()
{
	void Add(T entity);
	void Update(T entity);
	void Delete(T entity);
	List<T> GetAll();
	T GetById(int id);
}
