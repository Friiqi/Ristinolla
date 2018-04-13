using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    class PersonInfoAndScore
    {
        public struct PersonIAscore
        {
            public static string firstName, lastName;
            public static DateTime dateOfBirth;

           public struct GameScores
            {
                public static float wins, losses, draws;
                public static float totalGamePlayDuration;
            }
        }
    }
}
