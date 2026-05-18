
using Generated.Server.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers;

public class DefaultController : DefaultApiController
{
    public override IActionResult GetItemById(Guid id)
    {
        return Ok("hello");
    }
}