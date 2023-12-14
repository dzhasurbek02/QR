using Microsoft.AspNetCore.Mvc;
using QR.Features.StaticQr;
using QR.Features.StaticQr.DecodingQr;

namespace QR.Controllers;

[ApiController]
[Route("[controller]")]
public class StaticQrController : ControllerBase
{
    private readonly IStaticQrService _service;

    public StaticQrController(IStaticQrService service)
    {
        _service = service;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateStaticQr([FromBody] DecodingQrRequest request)
    {
        await _service.DecodingQr(request);

        return Ok("StaticQr decoded");
    }
}