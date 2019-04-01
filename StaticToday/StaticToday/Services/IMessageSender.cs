using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticToday.Services
{
	public class MessageService
	{
		IMessageSender _sender;
		public MessageService(IMessageSender sender)
		{
			_sender = sender;
		}
		public string SendMessage()
		{
			return _sender.Send(); 
		}
	}
	public interface IMessageSender
	{
		string Send();
	}
	public class EmailMessageSender : IMessageSender
	{
		public string Send()
		{
			return "Message is sent by email";
		}
	}
	public class SmsMessageSender : IMessageSender
	{
		public string Send()
		{
			return "Message is sent by sms";
		}
	}
}
