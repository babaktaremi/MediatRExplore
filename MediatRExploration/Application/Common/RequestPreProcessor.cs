using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace MediatRExploration.Application.Common
{
    public class RequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger<RequestPreProcessor<TRequest>> _logger;

        public RequestPreProcessor(ILogger<RequestPreProcessor<TRequest>> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            _logger.LogWarning($"Handling {typeof(TRequest)} Request");
        }
    }
}
