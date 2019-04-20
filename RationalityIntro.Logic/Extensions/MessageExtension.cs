using RationalityIntro.Data.DataModels;
using RationalityIntro.Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Extensions
{
    public static class MessageExtension
    {
        public static MessageDto ToMessageDto(this Message message)
        {
            if (message == null)
                return null;

            var messageDto = new MessageDto
            {
                Id = message.Id,
                ActId = message.ActId,
                Text = message.Text

            };

            return messageDto;
        }
    }
}
