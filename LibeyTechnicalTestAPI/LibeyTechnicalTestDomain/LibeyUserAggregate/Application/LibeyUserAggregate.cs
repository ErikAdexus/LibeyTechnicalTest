using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class LibeyUserAggregate : ILibeyUserAggregate
    {
        private readonly ILibeyUserRepository _repository;
        public LibeyUserAggregate(ILibeyUserRepository repository)
        {
            _repository = repository;
        }
        public void Create(LibeyUser libeyUser)
        {
         _repository.Create(libeyUser);
        }
        public LibeyUserResponse FindResponse(string documentNumber)
        {
            var row = _repository.FindResponse(documentNumber);
            return row;
        }
        public List<LibeyUserResponse> AllLibeyUser()
        {
            var row = _repository.AllLibeyUser();
            return row;
        }

        public void UpdateLibeyUser(string documentNumber,UserUpdateorCreateCommand command)
        {
            _repository.UpdateLibeyUser( documentNumber,command);
            
        }
        public void DeleteLibeyUser(string documentNumber)
        {
            _repository.DeleteLibeyUser(documentNumber);

        }
    }
}