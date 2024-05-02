using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepStepWebSiteApp.Entity.Entities;

namespace StepStepWebSiteApp.Business.Abstract;
public interface IMessageService : IGenericService<Message>
{
	List<Message> GetUnreadMessages();
	List<Message> GetReadMessages();
	List<Message> GetDeletedMessages();
	List<Message> GetListMessagesSortedByDateAsc();
	List<Message> GetListMessagesSortedByDateDesc();
	Message GetByEmail(string email);
}
