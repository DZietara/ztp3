using Ardalis.GuardClauses;
using Eshop.Contracts.Shared;
using Eshop.Infrastructure.Metrics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Eshop.API.Controllers
{
    [ApiController]
    [Route("api/v1/metrics")]
    public class MetricsController(IMetricsService metricsService) : ControllerBase
    {
        private readonly IMetricsService _metricsService = Guard.Against.Null(metricsService, nameof(metricsService));

        /// <summary>
        ///  Get metrics for errors.
        /// </summary>
        /// <returns>Metrics for errors.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(MetricsDto), (int)HttpStatusCode.OK)]
        public IActionResult GetMetrics()
        {
            var metrics = _metricsService.GetErrorMetrics();
            return Ok(metrics);
        }
    }
}
