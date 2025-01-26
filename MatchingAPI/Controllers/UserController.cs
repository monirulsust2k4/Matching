using MatchingAPI.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MatchingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public UserController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("GetAllUsers")]
        [HttpGet]
        public async Task<IActionResult> GetAllUsers(long accountId)
        {
            var res = await _employeeService.GetUsers(accountId);
            return Ok(res);
        }
    }
}
