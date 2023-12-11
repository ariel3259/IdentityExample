using IdentityApi.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddIdentityCookies();*/
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("db"));

builder.Services.AddIdentityApiEndpoints<Users>()
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddAuthorization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapGroup("/identity").MapIdentityApi<Users>();

app.MapControllers();

app.Run();
