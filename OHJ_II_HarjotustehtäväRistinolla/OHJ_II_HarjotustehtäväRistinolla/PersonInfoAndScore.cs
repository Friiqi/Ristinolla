﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    class PersonInfoAndScore
    {
        [Serializable]
        public struct Person
        {
            public string firstName, lastName;
            public DateTime dateOfBirth;

          
        }
        [Serializable]
        public struct GameScores
        {
            public Person personScores;
            public float wins, losses, draws;
            public float totalGamePlayDuration;
        }
    }
}
