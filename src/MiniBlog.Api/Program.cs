var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfra(builder.Configuration);

builder.Services.AddRouting(opts => opts.LowercaseUrls = true);
builder.Services
    .AddControllers()
    .AddApplicationPart(
        Assembly.Load(new AssemblyName("MiniBlog.Presentation")));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
