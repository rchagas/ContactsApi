using BrunskerApi.Services.Exceptions;
using ContactsApi.Models;
using ContactsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {

        private readonly UserService userService;
        public UserController(UserService userService) {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers() {
            return await userService.FindAllAsync();
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<User> GetUser(int id) 
        {
            return await userService.FindByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(
          [FromBody] User user) 
          {
            if (ModelState.IsValid) {
                await userService.AddAsync(user);
                return user;
            }
            else return BadRequest(ModelState);
        }
        [HttpPut]
        public async Task<ActionResult<User>> Put(
            [FromBody] User user) 
        {
            if (ModelState.IsValid) 
            {
                await userService.UpdateAsync(user);
                return user;
            }
            else return BadRequest(ModelState);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await userService.FindByIdAsync(id);
            try {
                await userService.DeleteAsync(user.Id);
                return user;
            }
            catch (NotFoundException) 
            {
                throw new NotFoundException("Id not Found");
            }
        }
        [HttpDelete]    
        [Route("Contact/{id:int}")]
        public async Task DeleteContact(int id) {
            try {
                await userService.DeleteContactAsync(id);
            }
            catch (NotFoundException) {
                throw new NotFoundException("Id not Found");
            }
        }

    }
}