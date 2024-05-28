namespace HundeRally.API.Domain.Entities
{
    public class Obstacle
    {
      

            public int Id { get; set; }
            public string Name { get; set; }           
            public int Number { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public ObstacleType Type { get; set; }
        }

        public enum ObstacleType
        {
            Stationær,
            Begynder,
            Øvet,
            Ekspert,
            Champion,
            BakkeØvelse,
            HøjreHandlet,
            Spring,
            Dobbeltspring,
            LøbEllerLangsom,
            StartAndFinish
        }

    }


