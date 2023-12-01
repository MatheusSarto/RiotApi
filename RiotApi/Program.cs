using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//add...
AddLolEndPoints(app);
AddValorantEndPoints(app);
AddTFTEndPoints(app);

app.UseExceptionHandler(errorApp => {
    errorApp.Run(async context => {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "application/json";

        var error = context.Features.Get<IExceptionHandlerPathFeature>();
        if (error != null)
        {
            await context.Response.WriteAsJsonAsync( new { 
                error = "An unexpected error occurred",
                details = error.Error.Message
            });
        }
    });
});

app.Run();
