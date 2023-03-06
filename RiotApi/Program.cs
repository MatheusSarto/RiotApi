var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//add...
AddLoLWatch(app);


app.Run();
