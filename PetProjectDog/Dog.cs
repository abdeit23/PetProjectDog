using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectDog
{
    public class Dog
    {
        public string Name { get; set; } // имя пса
        public string Age { get; set; } // возраст
        public double Weight { get; set; } // вес

        public string Colour { get; set; } // Цвет

        public bool IsFriendly { get; set; } // дружелюбна?

        public string Breed { get; set; } // порода

        public string SpecialFeatures { get; set; } // особые приметы

        public List<string> Notes { get; set; } = new List<string>(); // список примечаний

        public bool IsVaccinated { get; set; }
        public DateTime LastVaccination { get; set; } // дата последней вакцины

        public DateTime NextVaccination { get; set; } // дата следуюущей вакцины

        public DateTime LastWalk { get; set; } // 
        public DateTime NextWalk { get; set; } // 
        public DateTime DateLastUpdate { get; set; } // Дата последнего обновления карточки

        public string PhotoPath { get; set; }  // Путь к фотографии

        public Owner Owner { get; set; } = new Owner(); // поле для владельца

        public Dog(string name, string age, double weight, string color, string breed, bool isFriendly, bool isVaccinated)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = color;
            Breed = breed;
            IsFriendly = isFriendly;
            IsVaccinated = isVaccinated;
        }
        public Dog()
        {
        }


        public void ShowMainInfo()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nПорода: {Breed}\n" +
                $"Дружелюбна: {IsFriendly}\nВакцинирована: {IsVaccinated}");
        }
        public override string ToString()
        {
            return $"Имя питомца: {Name}, Порода: {Breed},Возраст: {Age} лет, Дата регистрации: {DateTime.Now.ToString("yyyy-MM-dd")}";
        }

        public void AddNote(string note)
        {
            Notes.Add(note);
        }
        public void MarkAsWalked()
        {
            LastWalk = DateTime.Now;
        }





    }
}
