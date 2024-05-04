using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Business.Abstract;
using StepStepWebSiteApp.DataAccess.Abstract;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Concrete;
public class MessageManager : IMessageService
{
	private readonly IMessageDal _messageDal;

	public MessageManager(IMessageDal messageDal)
	{
		_messageDal = messageDal;
	}

	public void Add(Message entity)
	{
		_messageDal.Add(entity);
	}

	public void Update(Message entity)
	{
		_messageDal.Update(entity);
	}

	public void Delete(Message entity)
	{
		_messageDal.Delete(entity);
	}

	public List<Message> GetAll()
	{
		return _messageDal.GetAll();
	}

	public Message GetById(int id)
	{
		return _messageDal.Get(m => m.Id == id);
	}

	public List<Message> GetUnreadMessages()
	{
		return _messageDal.GetAll(m => m.IsRead == false);
	}

	public List<Message> GetReadMessages()
	{
		return _messageDal.GetAll(m => m.IsRead == true);
	}

	public List<Message> GetDeletedMessages()
	{
		return _messageDal.GetAll(m => m.IsDeleted == true);
	}

	public List<Message> GetListMessagesSortedByDateAsc()
	{
		return _messageDal.GetAll().OrderBy(m => m.CreatedAt).ToList();
	}

	public List<Message> GetListMessagesSortedByDateDesc()
	{
		return _messageDal.GetAll().OrderByDescending(m => m.CreatedAt).ToList();
	}

	public Message GetByEmail(string email)
	{
		return _messageDal.Get(m => m.Email == email);
	}
}
