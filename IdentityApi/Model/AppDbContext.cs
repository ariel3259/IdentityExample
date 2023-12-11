using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApi.Model
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): IdentityDbContext<Users>(options)
    {

    }
}
