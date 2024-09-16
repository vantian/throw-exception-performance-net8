using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using throw_exception_performance.Business.Interfaces;
using throw_exception_performance.Models;

namespace throw_exception_performance.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IUserService _userService;

        public CustomerController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dat = await _userService.GetAll();
            return dat.IsSuccess ? Ok(dat) : BadRequest(dat);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerModel input)
        {
            var dat = await _userService.Insert(input);
            return dat.IsSuccess ? Ok(dat) : BadRequest(dat);
        }
    }
}
