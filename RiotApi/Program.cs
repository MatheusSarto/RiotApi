var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//add...
AddLoLSummoners(app);
AddLoLSpectator(app);
AddLoLWatch(app);


app.Run();
