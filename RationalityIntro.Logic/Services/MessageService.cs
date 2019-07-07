using RationalityIntro.Data;
using RationalityIntro.Data.DataModels;
using RationalityIntro.Data.Repository;
using RationalityIntro.Logic.Dto;
using RationalityIntro.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Services
{
    public interface IMessageService
    {

        MessageDto GetMessageById(int Id);

        void Delete(int Id);
    } 
    public class MessageService : IMessageService
    {
        private readonly MessageRepository messageRepository
            = new MessageRepository();

        public void Add(Message message)
        {
            messageRepository.AddMessage(message);
        }

        public void Delete(int Id)
        {
            messageRepository.DeleteMessage(Id);
        }

        public MessageDto GetMessageById(int Id)
        {
            var message = messageRepository.GetMessageById(Id);

            return message.ToMessageDto();
        }

    }
}
