using System.ComponentModel.DataAnnotations;
using System;

namespace Mandatory_assignment_1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public override string? ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }

        public void ValidateId()
        {
            if (Id < 0)
            {
                throw new IllegalIdException($"Id can't be negative: '{Id}'");
            }
        }

        public void ValidateName()
        {
            if (Name.Length < 2)
            {
                throw new IllegalNameException($"Name's length is required to be higher than 1: '{Name.Length}', '{Name}'");
            }
        }
        public void ValidateAge()
        {
            if (Age < 1)
            {
                throw new IllegalAgeException($"Age is required to be higher than 0: '{Age}'");
            }
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber > 99 || ShirtNumber < 1)
            {
                throw new IllegalShirtNumberException($"ShirtNumber's is required to be higher than 0 and lower than 100: '{ShirtNumber}'");
            }
        }

        public void Validate()
        {
            ValidateId();
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }

    }

    public class IllegalIdException : Exception
    {
        public IllegalIdException(string message)
            : base(message)
        {
        }
    }

    public class IllegalNameException : Exception
    {
        public IllegalNameException(string message)
            : base(message)
        {
        }
    }

    public class IllegalAgeException : Exception
    {
        public IllegalAgeException(string message)
            : base(message)
        {
        }
    }

    public class IllegalShirtNumberException : Exception
    {
        public IllegalShirtNumberException(string message)
            : base(message)
        {
        }
    }
}

