using TaskAPI.Services;
using TaskAPI.Services.Authors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers( options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITodoHelperServices, TodoDataService>();
builder.Services.AddScoped<IAuthorHelperService, AutherHelperService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler(app =>
    {

        app.Run(async context =>
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("There is an error in server. Please contact administrator.");
        });

    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
