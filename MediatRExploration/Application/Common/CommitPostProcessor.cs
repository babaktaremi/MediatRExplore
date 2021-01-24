using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace MediatRExploration.Application.Common
{
    public class CommitPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly ILogger<RequestPostProcessor<TRequest, TResponse>> _logger;

        public CommitPostProcessor(ILogger<RequestPostProcessor<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            if (request is ICommitable)
            {
                _logger.LogWarning("Saving Changes to the database");
            }
        }
    }
}
