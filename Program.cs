using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

List<RandomEvent> yearlyEvents = new List<RandomEvent>
{
    new RandomEvent { Id = 1, Name = "Pope dies" },
    new RandomEvent { Id = 2, Name = "International Aglet Day" },
    new RandomEvent { Id = 3, Name = "The everything coin crashed...big surprise" },
};

//get all yearly events
app.MapGet(
    "/api/yearlyevents",
    () =>
    {
        try
        {
            return Results.Ok(
                yearlyEvents.Select(ye => new RandomEventDTO { Id = ye.Id, Name = ye.Name })
            );
        }
        catch
        {
            return Results.NotFound();
        }
    }
);

//get a yearly event by Id
app.MapGet(
    "/yearlyevents/{id}",
    (int id) =>
    {
        try
        {
            RandomEvent foundRandomEvent = yearlyEvents.First(ye => id == ye.Id);
            return Results.Ok(
                new RandomEventDTO { Id = foundRandomEvent.Id, Name = foundRandomEvent.Name }
            );
        }
        catch
        {
            return Results.NotFound();
        }
    }
);

app.Run();
