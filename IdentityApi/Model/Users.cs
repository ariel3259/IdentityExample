using Microsoft.AspNetCore.Identity;

namespace IdentityApi.Model
{
    public class Users: IdentityUser
    {
        public int Dni { get; set; }
    }
}
