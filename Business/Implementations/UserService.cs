using throw_exception_performance.Business.Interfaces;
using throw_exception_performance.Models;

namespace throw_exception_performance.Business.Implementations
{
    public class UserService : IUserService
    {

        public async Task<ResponseBase<List<CustomerModel>>> GetAll()
        {
            //return list of sample customers
            ResponseBase<List<CustomerModel>> resp = new() { 
                Data = new List<CustomerModel>()
            };

            for (int i = 0; i < 100; i++)
            {
                //make i to two string digit format
                resp.Data.Add(new CustomerModel { Name = $"John Doe #{i.ToString("00")}", Email = "" });
            }

            return resp;
        }


        public async Task<ResponseBase<string>> Insert(CustomerModel input)
        {
            //return list of sample customers
            ResponseBase<string> resp = new() {
                Data = "OK"
            };

            if (string.IsNullOrEmpty(input.Name) || string.IsNullOrEmpty(input.Email))
                return new ResponseBase<string> { Data = "Not OK", IsSuccess = false, Message = "Name and Email are required" };

            //try
            //{ 
            //    if(string.IsNullOrEmpty(input.Name) || string.IsNullOrEmpty(input.Email))
            //        throw new Exception("Name and Email are required");
            //}
            //catch (Exception ex)
            //{
            //    resp.IsSuccess = false;
            //    resp.Message = ex.Message;
            //}

            return resp;
        }
    }
}
