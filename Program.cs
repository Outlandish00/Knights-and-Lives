using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

List<RandomEvent> yearlyEvents = new List<RandomEvent>
{
    new RandomEvent { Id = 1, Name = "King’s crown mysteriously vanishes, causing chaos" },
    new RandomEvent { Id = 2, Name = "Wizards declare war on all knights for bad haircuts" },
    new RandomEvent { Id = 3, Name = "Dragon mysteriously starts running a bakery" },
    new RandomEvent { Id = 4, Name = "Plague turns out to be an elaborate prank" },
    new RandomEvent { Id = 5, Name = "Knight accidentally knights a chicken, causing confusion" },
    new RandomEvent { Id = 6, Name = "Peasants discover a hidden treasure map in a loaf of bread" },
    new RandomEvent { Id = 7, Name = "A rogue jester becomes the new ruler of the kingdom" },
    new RandomEvent
    {
        Id = 8,
        Name = "Magical portal opens, but it only leads to the next village over",
    },
    new RandomEvent
    {
        Id = 9,
        Name = "King’s new pet griffin becomes the kingdom’s top fashion model",
    },
    new RandomEvent { Id = 10, Name = "Royal knight loses his sword, finds a broom instead" },
    new RandomEvent { Id = 11, Name = "Bandits mistakenly rob a tavern full of wizards" },
    new RandomEvent
    {
        Id = 12,
        Name = "Unicorns refuse to leave the royal garden, causing a diplomatic crisis",
    },
    new RandomEvent { Id = 13, Name = "A mysterious enchanted mirror starts offering life advice" },
    new RandomEvent
    {
        Id = 14,
        Name = "A sorcerer accidentally turns all the horses into giant ducks",
    },
    new RandomEvent { Id = 15, Name = "King's castle is invaded by a horde of sentient turnips" },
    new RandomEvent { Id = 16, Name = "A giant cat from the mountains claims the throne" },
    new RandomEvent { Id = 17, Name = "A comet falls, but it’s just a giant apple pie" },
    new RandomEvent
    {
        Id = 18,
        Name = "A magical fog appears, but it only makes everyone really sleepy",
    },
    new RandomEvent
    {
        Id = 19,
        Name = "A knight’s quest ends with him becoming a professional sheep herder",
    },
    new RandomEvent
    {
        Id = 20,
        Name = "A bard writes a song so beautiful, it causes all swords to break",
    },
    new RandomEvent
    {
        Id = 21,
        Name = "A traveling circus of wizards and knights perform an epic show",
    },
    new RandomEvent
    {
        Id = 22,
        Name = "Peasants discover a talking rabbit who claims to be a fallen prince",
    },
    new RandomEvent
    {
        Id = 23,
        Name = "The king declares every Thursday to be 'Dress Like a Dragon' day",
    },
    new RandomEvent
    {
        Id = 24,
        Name = "An enchanted sword becomes sentient and demands a new owner",
    },
    new RandomEvent
    {
        Id = 25,
        Name = "The kingdom is cursed to only speak in rhymes for a full week",
    },
};

List<FamilyName> familyNames = new List<FamilyName>
{
    new FamilyName
    {
        Id = 1,
        Name = "Reagans",
        IsRoyalty = true,
        IsWarrior = false,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 2,
        Name = "Woodson",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 3,
        Name = "Borne of the Dragon",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 4,
        Name = "Fielding",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 5,
        Name = "Clay",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
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

app.MapGet(
    "/api/familynames",
    () =>
    {
        try
        {
            return Results.Ok(
                familyNames.Select(fn => new FamilyNameDTO
                {
                    Id = fn.Id,
                    Name = fn.Name,
                    IsRoyalty = fn.IsRoyalty,
                    IsWarrior = fn.IsWarrior,
                    IsPeasant = fn.IsPeasant,
                })
            );
        }
        catch
        {
            return Results.NotFound();
        }
    }
);

app.Run();
