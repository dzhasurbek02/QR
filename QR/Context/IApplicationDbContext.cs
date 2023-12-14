using Microsoft.EntityFrameworkCore;
using QR.Entity;

namespace QR.Context;

public interface IApplicationDbContext
{
    public DbSet<StaticQr> StaticQrs { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}