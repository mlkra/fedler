using FedlerApi.infrastructure;
using FedlerApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SupportNonNullableReferenceTypes();
});
builder.Services.AddHttpClient();

builder.Services.AddScoped<IFeedRepository, FeedRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(builder => 
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
