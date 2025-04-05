using EscoteiroLMS.Api.Controllers.Contact.Dto;

namespace EscoteiroLMS.Application
{
    public interface IContactUseCase
    {
        Task Execute(ContactRequestDto requestSendEmail);
    }
}