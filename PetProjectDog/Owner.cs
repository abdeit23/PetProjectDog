using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectDog
{
    public class Owner
    {
        public string Name { get; set; } 

        public string PhoneNumber { get; set; }

        
        public void ShowInfo ()
        {
            Console.WriteLine($"Имя: {Name}, тел: {PhoneNumber}");
        }
    }
}
