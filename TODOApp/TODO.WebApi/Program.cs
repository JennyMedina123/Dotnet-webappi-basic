using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TODO.WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TODOAppDbContext>(Options => 
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnetion"));
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var  services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<TODOAppDbContext>();
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
    }
    catch (Exception ex) 
    {
      // Aqui puedes manejar cualquier error que pueda surgir, por ejemplo utilizando un logger
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Un error ocurrio al aplicar las migraciones.");
    }
    
}
    
   
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseRouting();
app.UseEndpoints(Endpoints =>
            {
                Endpoints.MapControllers();
            }
);

app.UseHttpsRedirection();


app.Run();
