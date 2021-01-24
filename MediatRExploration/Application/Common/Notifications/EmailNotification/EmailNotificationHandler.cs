using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace MediatRExploration.Application.Common.Notifications.EmailNotification
{
    public class EmailNotificationHandler:INotificationHandler<EmailNotification>
    {
        private readonly ILogger<EmailNotificationHandler> _logger;

        public EmailNotificationHandler(ILogger<EmailNotificationHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(EmailNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogWarning("Sending Email to {EmailAddress} with content {EmailContent}",notification.EmailAddress,notification.EmailContent);
            return Task.CompletedTask;
        }
    }
}
