using Microsoft.EntityFrameworkCore;

namespace LoggingAuditApi.Infrastructure;

public class LoggingAuditApiDbContext : DbContext
{
    public LoggingAuditApiDbContext(DbContextOptions<LoggingAuditApiDbContext> options)
        : base(options) { }
}
