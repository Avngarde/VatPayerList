using VatPayersList.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/getVatPayerByNip", async (string nip) =>
{
    HttpClient httpClient = new();
    var response = await httpClient.GetAsync(
        $"https://wl-api.mf.gov.pl/api/search/nip/{nip}?date={DateTime.Now:yyyy-MM-dd}"
    );

    if (!response.IsSuccessStatusCode)
    {
        var apiException = await response.Content.ReadFromJsonAsync<ApiException>();

        return Results.BadRequest(apiException);
    }  

    var entity = await response.Content.ReadFromJsonAsync<EntityResponse>();

    return Results.Ok(entity);
})
.WithName("GetVatPayerByNip")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
