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
    new FamilyName
    {
        Id = 6,
        Name = "Robertson",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 7,
        Name = "Richards",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 8,
        Name = "Parker",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 9,
        Name = "Dismay",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 10,
        Name = "DungEater",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 11,
        Name = "Riddle",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 12,
        Name = "Uzumaku",
        IsRoyalty = true,
        IsWarrior = false,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 13,
        Name = "Bubbles",
        IsRoyalty = true,
        IsWarrior = false,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 14,
        Name = "Wesson",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 15,
        Name = "The Last",
        IsRoyalty = false,
        IsWarrior = true,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 16,
        Name = "Byars",
        IsRoyalty = true,
        IsWarrior = false,
        IsPeasant = false,
    },
    new FamilyName
    {
        Id = 17,
        Name = "Simuluth",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 18,
        Name = "Turs",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 19,
        Name = "Curro",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 20,
        Name = "Sarth",
        IsRoyalty = false,
        IsWarrior = false,
        IsPeasant = true,
    },
    new FamilyName
    {
        Id = 21,
        Name = "Skywalker",
        IsRoyalty = true,
        IsWarrior = false,
        IsPeasant = false,
    },
};

//MajorEvent types, to allow or not allow certain events if they are royalty or not for example
List<MajorEventType> majorEventTypes = new List<MajorEventType>
{
    new MajorEventType() { Id = 1, Type = "Financial" },
    new MajorEventType() { Id = 2, Type = "War" },
    new MajorEventType() { Id = 3, Type = "Royalty" },
    new MajorEventType() { Id = 4, Type = "Random" },
};
List<PlayerStat> playerStats = new List<PlayerStat>
{
    new PlayerStat
    {
        Id = 1,
        Name = "Health",
        Value = 100,
    },
    new PlayerStat
    {
        Id = 2,
        Name = "Hygeine",
        Value = 100,
    },
    new PlayerStat
    {
        Id = 3,
        Name = "Food",
        Value = 100,
    },
    new PlayerStat
    {
        Id = 4,
        Name = "Mood",
        Value = 100,
    },
};

//lists of Major Events (These will affect the game in some way. Stats, gold, etc.)
List<RandomMajorEvent> majorEvents = new List<RandomMajorEvent>
{
    new RandomMajorEvent
    {
        Id = 1,
        MajorEventTypeId = 4,
        EventTitle = "Shady Alchemist",
        Description =
            "An alchemist approaches you, offering you a gilded potion. He states he is giving free samples to spread his business, do you accept the potion?",
        Choices = new List<EventChoice>
        {
            new EventChoice
            {
                Id = 1,
                ChoiceDescription = "Drink the gilded potion",
                PositiveOutcome = "The Alchemist was a skilled one, health increased ",
                NegativeOutcome = "Slimy alchemist, this potion was a poison",
                PositiveProbability = 20,
            },
            new EventChoice
            {
                Id = 2,
                ChoiceDescription = "Walk away, you can't trust them.",
                PositiveOutcome = "You walked away.",
                NegativeOutcome = "The alechimst's dignity is hurt, he hurls the potion at you",
            },
        },
    },
    new RandomMajorEvent()
    {
        Id = 2,
        MajorEventTypeId = 4,
        EventTitle = "A stranger in need",
        Description = "You find a peasant laying in the road, appearing to have been knocked down.",
        Choices = new List<EventChoice>
        {
            new EventChoice
            {
                Id = 3,
                ChoiceDescription = "You take their hand, pulling them to their feet.",
                PositiveOutcome =
                    "They smile at you, and reach out the little coins they have as a thank you.",
                NegativeOutcome =
                    "As you grab their hand, you hear metal unsheating, and the sting in your ribs follow shortly after",
                PositiveProbability = 80,
            },
            new EventChoice
            {
                Id = 4,
                ChoiceDescription = "Walk away, you can't trust people in this world.",
                PositiveOutcome = " You walk away, perhaps dooming a person, but being unscathed",
                NegativeOutcome =
                    "Your gut was correct, the peasant tosses a dagger at you as you turn",
                PositiveProbability = 90,
            },
        },
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

app.MapGet(
    "/api/random-major-event",
    () =>
    {
        Random rand = new Random();
        RandomMajorEvent randomEvent = majorEvents[rand.Next(majorEvents.Count)];
        if (randomEvent.Choices == null || randomEvent.Choices.Count == 0)
        {
            Console.WriteLine("No choices available for this event.");
        }
        RandomMajorEventDTO randomEventDTO = new RandomMajorEventDTO
        {
            Id = randomEvent.Id,
            MajorEventTypeId = randomEvent.MajorEventTypeId,
            EventTitle = randomEvent.EventTitle,
            Description = randomEvent.Description,
            Choices = randomEvent
                .Choices.Select(choice => new EventChoicesDTO
                {
                    Id = choice.Id,
                    ChoiceDescription = choice.ChoiceDescription,
                    PositiveOutcome = choice.PositiveOutcome,
                    NegativeOutcome = choice.NegativeOutcome,
                    PositiveProbability = choice.PositiveProbability,
                })
                .ToList(),
        };
        return Results.Ok(randomEventDTO);
    }
);

app.Run();
