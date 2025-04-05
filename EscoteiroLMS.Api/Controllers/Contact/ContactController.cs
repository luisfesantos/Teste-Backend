using EscoteiroLMS.Api.Controllers.Contact.Dto;
using EscoteiroLMS.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EscoteiroLMS.Api.Controllers.Contact
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] ContactRequestDto request, [FromServices] IContactUseCase useCase)
        {
            await useCase.Execute(request);
            return Ok();

        }
    }
}
