var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//add...
AddLoLStatus(app);
AddLoLSummonerInfo(app);

app.Run();
