using CoinJar.Classes;
using Swashbuckle.AspNetCore.Annotations;

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


app.MapPost("/coin/add", (decimal Amount, decimal Volume) =>
{
    var coinJar = new CoinJar.Classes.CoinJar();
    var coin = new Coin(Amount, Volume);
    coinJar.AddCoin(coin);
    return true;
})
.WithName("AddCoin")
.WithMetadata(new SwaggerOperationAttribute("Add Coin", "Add 1 coin to the coin jar"));

app.MapGet("/coin/total", () =>
{
    var coinJar = new CoinJar.Classes.CoinJar();
    var total = coinJar.GetTotalAmount();
    return total;
})
.WithName("GetCoinTotal")
.WithMetadata(new SwaggerOperationAttribute("Get Total Coins", "Get the total amount of coins in the coin jar"));

app.MapGet("/coin/reset", () =>
{
    var coinJar = new CoinJar.Classes.CoinJar();
    coinJar.Reset();
    return true;
})
.WithName("ResetCoinJar")
.WithMetadata(new SwaggerOperationAttribute("Reset Coin Jar", "Empty coin jar"));

app.Run();
