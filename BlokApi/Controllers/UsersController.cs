using AutoMapper;
using Data.Repositories.IRepository;
using Data.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
            public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper=mapper;
        }
        [HttpPost]   

        public IActionResult Athenticate(UserDto userDto)
        {
            var user = _userService.Authenticate(userDto.UserName,userDto.Password);
            if (user == null)
            {
                return BadRequest(new { messsage = "Kullanıcı adı veya parola hatalı" });
            }
             
            return Ok(user);
        }
        [HttpPost("register")]
        public IActionResult Register(UserDto userDto)
        {
            bool userBool = _userService.IsUniqueUser(userDto.UserName);
            if (!userBool)
            {
                return BadRequest(new { message = "Kullanıcı adı zaten kayıtlı" });
            }

            var user = _userService.Register(userDto.UserName, userDto.Password);

            if (user == null)
            {
                return BadRequest(new { message = "Kayıt esnasında hata oluştu" });
            }

            return Ok();

        }

    }
}
