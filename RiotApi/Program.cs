var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//add...
AddLoLSummoners(app);
AddLoLSpectator(app);
AddLoLWatch(app);
AddLoLStatus(app);


app.Run();
