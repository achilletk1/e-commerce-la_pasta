using Microsoft.EntityFrameworkCore;

namespace AuthUsersApi.Infrastructure;

public class AuthUsersApiDbContext : DbContext
{
    public AuthUsersApiDbContext(DbContextOptions<AuthUsersApiDbContext> options)
        : base(options) { }
}
