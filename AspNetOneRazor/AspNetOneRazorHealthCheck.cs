using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AspNetOneRazor
{
    public class AspNetOneRazorHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy(DateTime.UtcNow.ToLongDateString()));
        }
    }
}
