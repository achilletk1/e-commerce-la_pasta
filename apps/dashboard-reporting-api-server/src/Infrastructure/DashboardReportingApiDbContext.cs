using Microsoft.EntityFrameworkCore;

namespace DashboardReportingApi.Infrastructure;

public class DashboardReportingApiDbContext : DbContext
{
    public DashboardReportingApiDbContext(DbContextOptions<DashboardReportingApiDbContext> options)
        : base(options) { }
}
