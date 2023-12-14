using QR.Features.StaticQr.DecodingQr;

namespace QR.Features.StaticQr;

public interface IStaticQrService
{
    public Task DecodingQr(DecodingQrRequest request);
}