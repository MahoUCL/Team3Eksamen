using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Logic.Entity
{
    public class ObstacleCourse
    {
        public string Name { get; set; }
        public CourseType CourseType { get; set; }
        public List<Obstacle> Obstacles { get; set; } = new List<Obstacle>();

        //This is designed to choose the courseType before designing the course, the validationmethods below will then validate the course for if the rules are abided by.
        public bool ValidateCourse()
        {
            switch (CourseType)
            {
                case CourseType.BegynderBane:
                    return ValidateBegynderBane();
                case CourseType.ØvetBane:
                    return ValidateØvetBane();
                case CourseType.EkspertBane:
                    return ValidateEkspertBane();
                case CourseType.ChampionBane:
                    return ValidateChampionBane();
                case CourseType.ÅbenBane:
                    return ValidateÅbenBane();
                default:
                    // Throw an exception or handle unexpected course type here
                    throw new ArgumentException("Invalid CourseType");
            }
        }



        //Validation for BegynderBane
        private bool ValidateBegynderBane()
        {
            int obstacleCount = Obstacles.Count;
            if (obstacleCount < 10 || obstacleCount > 15)
            {
                return false;
            }

            int stationaryCount = Obstacles.Count(o => o.Type == ObstacleType.Stationær);
            if (stationaryCount > 5)
            {
                return false;
            }

            return true;
        }


        //Validation for ØvetBane
        private bool ValidateØvetBane()
        {
            int obstacleCount = Obstacles.Count;
            if (obstacleCount < 12 || obstacleCount > 17)
            {
                return false;
            }

            int stationaryCount = Obstacles.Count(o => o.Type == ObstacleType.Stationær);
            if (stationaryCount > 7)
            {
                return false;
            }

            int øvetCount = Obstacles.Count(o => o.Type == ObstacleType.Øvet);
            if (øvetCount < 5)
            {
                return false;
            }

            int springCount = Obstacles.Count(o => o.Type == ObstacleType.Spring);
            if (springCount > 1)
            {
                return false;
            }

            int løbLangsomCount = Obstacles.Count(o => o.Type == ObstacleType.LøbEllerLangsom);
            if (løbLangsomCount > 1)
            {
                return false;
            }

            int højreHandletCount = Obstacles.Count(o => o.Type == ObstacleType.HøjreHandlet);
            if (højreHandletCount > 1)
            {
                return false;
            }

            return true;
        }


        //Validation for EkspertBane
        private bool ValidateEkspertBane()
        {
            int obstacleCount = Obstacles.Count;
            if (obstacleCount < 16 || obstacleCount > 20)
            {
                return false;
            }

            int stationaryCount = Obstacles.Count(o => o.Type == ObstacleType.Stationær);
            if (stationaryCount > 7)
            {
                return false;
            }

            int øvetCount = Obstacles.Count(o => o.Type == ObstacleType.Øvet);
            if (øvetCount < 5)
            {
                return false;
            }

            int ekspertCount = Obstacles.Count(o => o.Type == ObstacleType.Ekspert);
            if (ekspertCount < 3)
            {
                return false;
            }

            int bakkeØvelseCount = Obstacles.Count(o => o.Type == ObstacleType.BakkeØvelse);
            if (bakkeØvelseCount > 4)
            {
                return false;
            }

            int højreHandletCount = Obstacles.Count(o => o.Type == ObstacleType.HøjreHandlet);
            if (højreHandletCount < 2 || højreHandletCount > 4)
            {
                return false;
            }

            // Check for consecutive right-handed obstacles
            int consecutiveHøjreHandletCount = 0;
            for (int i = 0; i < obstacleCount; i++)
            {
                if (Obstacles[i].Type == ObstacleType.HøjreHandlet)
                {
                    consecutiveHøjreHandletCount++;
                    if (consecutiveHøjreHandletCount > 2)
                    {
                        return false;
                    }
                }
                else
                {
                    consecutiveHøjreHandletCount = 0;
                }
            }

            // Check if first obstacle is right-handed
            if (Obstacles[0].Type != ObstacleType.HøjreHandlet)
            {
                return false;
            }

            return true;
        }

        //Validation for ChampionBane
        private bool ValidateChampionBane()
        {
            int obstacleCount = Obstacles.Count;
            if (obstacleCount < 18 || obstacleCount > 20)
            {
                return false;
            }

            int stationaryCount = Obstacles.Count(o => o.Type == ObstacleType.Stationær);
            if (stationaryCount > 7)
            {
                return false;
            }

            int øvetCount = Obstacles.Count(o => o.Type == ObstacleType.Øvet);
            if (øvetCount < 4)
            {
                return false;
            }

            int ekspertCount = Obstacles.Count(o => o.Type == ObstacleType.Ekspert);
            if (ekspertCount < 1)
            {
                return false;
            }

            int championCount = Obstacles.Count(o => o.Type == ObstacleType.Champion);
            if (championCount < 5)
            {
                return false;
            }

            int bakkeØvelseCount = Obstacles.Count(o => o.Type == ObstacleType.BakkeØvelse);
            if (bakkeØvelseCount > 4)
            {
                return false;
            }

            int springCount = Obstacles.Count(o => o.Type == ObstacleType.Spring);
            int dobbeltspringCount = Obstacles.Count(o => o.Type == ObstacleType.Dobbeltspring);
            int totalSpringCount = springCount + dobbeltspringCount;
            if (totalSpringCount > 3 || springCount > 2 || dobbeltspringCount > 2)
            {
                return false;
            }

            int højreHandletCount = Obstacles.Count(o => o.Type == ObstacleType.HøjreHandlet);
            if (højreHandletCount < 4 || højreHandletCount > 3)
            {
                return false;
            }

            // Check for consecutive right-handed obstacles
            int consecutiveHøjreHandletCount = 0;
            for (int i = 0; i < obstacleCount; i++)
            {
                if (Obstacles[i].Type == ObstacleType.HøjreHandlet)
                {
                    consecutiveHøjreHandletCount++;
                    if (consecutiveHøjreHandletCount > 3)
                    {
                        return false;
                    }
                }
                else
                {
                    consecutiveHøjreHandletCount = 0;
                }
            }

            // Check if first obstacle is right-handed
            if (Obstacles[0].Type != ObstacleType.HøjreHandlet)
            {
                return false;
            }

            return true;
        }

        //Validation for ÅbenBane
        private bool ValidateÅbenBane()
        {
            int obstacleCount = Obstacles.Count;
            if (obstacleCount < 15 || obstacleCount > 18)
            {
                return false;
            }

            int stationaryCount = Obstacles.Count(o => o.Type == ObstacleType.Stationær);
            if (stationaryCount > 8)
            {
                return false;
            }

            int begynderCount = Obstacles.Count(o => o.Type == ObstacleType.Begynder);
            if (begynderCount < 4 || begynderCount > 8)
            {
                return false;
            }

            int øvetCount = Obstacles.Count(o => o.Type == ObstacleType.Øvet);
            if (øvetCount < 4 || øvetCount > 5)
            {
                return false;
            }

            int ekspertCount = Obstacles.Count(o => o.Type == ObstacleType.Ekspert);
            if (ekspertCount < 2 || ekspertCount > 4)
            {
                return false;
            }

            int championCount = Obstacles.Count(o => o.Type == ObstacleType.Champion);
            if (championCount < 2 || championCount > 4)
            {
                return false;
            }

            int bakkeØvelseCount = Obstacles.Count(o => o.Type == ObstacleType.BakkeØvelse);
            if (bakkeØvelseCount > 3)
            {
                return false;
            }

            int springCount = Obstacles.Count(o => o.Type == ObstacleType.Spring);
            if (springCount > 3)
            {
                return false;
            }

            int højreHandletBegynderCount = Obstacles.Count(o => o.Type == ObstacleType.HøjreHandlet && o.Type == ObstacleType.Begynder);
            if (højreHandletBegynderCount > 1)
            {
                return false;
            }

            return true;
        }

    }

    public enum CourseType
    {
        BegynderBane,
        ØvetBane,
        EkspertBane,
        ChampionBane,
        ÅbenBane
    }

}


