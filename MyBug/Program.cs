using Microsoft.EntityFrameworkCore;
using MyBug.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BugDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("bugs")));
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
