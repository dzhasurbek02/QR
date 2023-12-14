using QR.Context;
using QR.Features.StaticQr.DecodingQr;

namespace QR.Features.StaticQr;

public class StaticQrService : IStaticQrService
{
    private readonly IApplicationDbContext _context;

    public StaticQrService(IApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task DecodingQr(DecodingQrRequest request)
    {
        Dictionary<string, string> Qr = new Dictionary<string, string>();

        int lastIndex=0;

        while (lastIndex < request.QrCode.Length)
        {
            var tag = request.QrCode.Substring(lastIndex, 2);
            lastIndex += 2;

            var length = int.Parse(request.QrCode.Substring(lastIndex, 2));
            lastIndex += 2;

            var value = request.QrCode.Substring(lastIndex, length);
            lastIndex += value.Length;
    
            Qr.Add(tag, value);
        }

        string tag00 = "";
        string tag01 = "";
        string tag31 = "";
        string tag52 = "";
        string tag53 = "";
        string tag58 = "";
        string tag59 = "";
        string tag60 = "";
        string tag62 = "";
        string tag63 = "";
        
        foreach (var kvp in Qr)
        {
            switch (kvp.Key)
            {
                case "00":
                    tag00 = kvp.Value;
                    break;
        
                case "01":
                    tag01 = kvp.Value;
                    break;
        
                case "31":
                    tag31 = kvp.Value;
                    break;
        
                case "52":
                    tag52 = kvp.Value;
                    break;
        
                case "53":
                    tag53 = kvp.Value;
                    break;
        
                case "58":
                    tag58 = kvp.Value;
                    break;
        
                case "59":
                    tag59 = kvp.Value;
                    break;
        
                case "60":
                    tag60 = kvp.Value;
                    break;
        
                case "62":
                    tag62 = kvp.Value;
                    break;
        
                case "63":
                    tag63 = kvp.Value;
                    break;
            }
        }

        var qr = new Entity.StaticQr()
        {
            ConstValue = tag00,
            StatQr = tag01,
            IdEQMS_Address = tag31,
            Category = tag52,
            CurrencyCode = tag53,
            CountryCode = tag58,
            CompanyName = tag59,
            CityWhereLocated = tag60,
            TradeServiceId_TerminalId = tag62,
            CRC = tag63
        };

        await _context.StaticQrs.AddAsync(qr);
        await _context.SaveChangesAsync();
    }
}