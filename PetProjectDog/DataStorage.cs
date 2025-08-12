using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetProjectDog
{
    public static class DataStorage
    {
        public static List<Dog> Dogs { get; private set; } = new List<Dog>();
        public static List<Owner> Owners { get; private set; } = new List<Owner>();
        private static string FilePath => "dogs.json";
        public static void SaveDogsToFile()
        {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dogs.json");

                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(Dogs, options);

                File.WriteAllText(path, json);
             
        }
        
        public static void LoadDogsFromFile()
        {
            if (!File.Exists(FilePath)) return;

            string json = File.ReadAllText(FilePath);
            try
            {
                Dogs = JsonSerializer.Deserialize<List<Dog>>(json) ?? new List<Dog>();
            }
            catch
            {
                Dogs = new List<Dog>();
            }
        }






    }
}
