using Microsoft.EntityFrameworkCore;

namespace FluxBank.Infrastructure.Persistence;

public class FluxBankDbContext : DbContext
{
    public FluxBankDbContext(
        DbContextOptions<FluxBankDbContext> options)
        : base(options)
    {
    }
}