using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MediatRExploration.Application.Common.Notifications.EmailNotification
{
    public class EmailNotification:INotification
    {
        public string EmailAddress { get; }
        public string EmailContent { get;  }

        public EmailNotification(string emailAddress, string emailContent)
        {
            EmailAddress = emailAddress;
            EmailContent = emailContent;
        }
    }
}
