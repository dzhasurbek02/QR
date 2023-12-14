using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QR.Entity;

namespace QR.Configurations;

public class StaticQRConfiguration : IEntityTypeConfiguration<StaticQr>
{
    public void Configure(EntityTypeBuilder<StaticQr> builder)
    {
        builder.Property(q => q.ConstValue)
            .IsRequired();

        builder.Property(q => q.StatQr)
            .IsRequired();

        builder.Property(q => q.IdEQMS_Address)
            .IsRequired();

        builder.Property(q => q.Category)
            .IsRequired();

        builder.Property(q => q.CurrencyCode)
            .IsRequired();

        builder.Property(q => q.CountryCode)
            .IsRequired();

        builder.Property(q => q.CompanyName)
            .IsRequired();

        builder.Property(q => q.CityWhereLocated)
            .IsRequired();

        builder.Property(q => q.TradeServiceId_TerminalId)
            .IsRequired();

        builder.Property(q => q.CRC)
            .IsRequired();
    }
}