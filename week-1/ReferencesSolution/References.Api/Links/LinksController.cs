
using Microsoft.AspNetCore.Mvc;

namespace References.Api.Links;


public class LinksController : ControllerBase
{
    //some code here that gets called when a GET /links is sent to this server.

    [HttpGet("/links")]
    public async Task<ActionResult> GetAllLinksAsync(CancellationToken token)
    {
        return Ok(); // returns a 200 ok instead of a 404
    }


}
