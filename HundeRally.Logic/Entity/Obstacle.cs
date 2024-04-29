using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Logic.Entity
{
    public class Obstacle
    {
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




