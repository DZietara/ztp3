using Eshop.Contracts.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Metrics
{
    public interface IMetricsService
    {
        void IncrementErrorCount(string errorType);
        MetricsDto GetErrorMetrics();
    }
}