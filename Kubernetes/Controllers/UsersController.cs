using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Kubernetes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly UsersContext context;

        public UsersController(UsersContext context)
        {
            this.context = context;
        }

        public List<User> GetAllUsers()
        {
            var users = this.context.Users.ToList();
            return users;

        }
    }
}