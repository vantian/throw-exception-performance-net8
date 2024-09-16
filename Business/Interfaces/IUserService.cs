using throw_exception_performance.Models;

namespace throw_exception_performance.Business.Interfaces
{
    public interface IUserService
    {
        Task<ResponseBase<List<CustomerModel>>> GetAll();
        Task<ResponseBase<string>> Insert(CustomerModel input);
    }
}
