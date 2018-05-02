using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OHJ_II_HarjotustehtäväRistinolla
{


        
        [Serializable]
        public struct Person
        {
            public string firstName, lastName;
            public DateTime dateOfBirth;

        public Guid Id;
            public string Displayname
            {
                get
                {
                    return $"{firstName} {lastName}";
                }
            }

        }
        [Serializable]
        public struct GameScores
        {
            public Person personScores;

            public float wins, losses, draws;
            public string totalGamePlayDuration;

            public static void Serialize(List<GameScores> listOfPlayers, string savePath)
            {
               

            string serializedJson = Newtonsoft.Json.JsonConvert.SerializeObject(listOfPlayers);
            // kirjoitetaan teksti tiedostoon
            System.IO.File.WriteAllText(savePath, serializedJson);


        }

        public static List<GameScores> DeserializeList(string savePath)
                {
            if (System.IO.File.Exists(savePath))
            {
                // deserialize JSON directly from a file
                
                string data = System.IO.File.ReadAllText(savePath);
                JsonSerializer serializer = new JsonSerializer();
                var gameScoresDeSerialized = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameScores>>(data);
                return gameScoresDeSerialized;
            }
            else
            {
                return new List<GameScores>();
            }
        }


        }
      
        
    
    }

