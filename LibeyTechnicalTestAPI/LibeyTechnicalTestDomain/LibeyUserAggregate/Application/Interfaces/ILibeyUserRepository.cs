using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface ILibeyUserRepository
    {
        LibeyUserResponse FindResponse(string documentNumber);
        void Create(LibeyUser libeyUser);

        List<LibeyUserResponse> AllLibeyUser();

        public void UpdateLibeyUser(string documentNumber, UserUpdateorCreateCommand command);

        public void DeleteLibeyUser(string documentNumber);
    }
}
