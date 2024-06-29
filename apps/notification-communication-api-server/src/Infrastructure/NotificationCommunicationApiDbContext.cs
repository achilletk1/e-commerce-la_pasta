using Microsoft.EntityFrameworkCore;

namespace NotificationCommunicationApi.Infrastructure;

public class NotificationCommunicationApiDbContext : DbContext
{
    public NotificationCommunicationApiDbContext(
        DbContextOptions<NotificationCommunicationApiDbContext> options
    )
        : base(options) { }
}
