namespace HundeRally.API.Domain.Entities
{
    public class CreateObstacleDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Number { get; set; }

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
}
