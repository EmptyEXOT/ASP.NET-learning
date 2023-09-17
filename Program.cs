var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.Run(async (context) =>
{
    var req = context.Request;

    if (!String.IsNullOrEmpty(req.Query["first"]) && !String.IsNullOrEmpty(req.Query["second"]))
        {
            int first = int.Parse(context.Request.Query["first"]);
            int second = int.Parse(context.Request.Query["second"]);
            await context.Response.WriteAsync($"{first+second}");
        }
    else
    {
        await context.Response.WriteAsync("bye!");
    }



});

app.Run();