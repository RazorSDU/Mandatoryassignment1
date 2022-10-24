using System.ComponentModel.DataAnnotations;
using System;

namespace Mandatory_assignment_1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 2)]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid age above 1")]
        public int Age { get; set; }
        [Range(1, 99, ErrorMessage = "Please enter a valid Shirt Number between 1-99")]
        public int ShirtNumber { get; set; }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }
    }
}

