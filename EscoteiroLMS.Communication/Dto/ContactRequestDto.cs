namespace EscoteiroLMS.Api.Controllers.Contact.Dto
{
    public record ContactRequestDto
        (
            string Name,
            string Email,
            string Message
        );
    
}
