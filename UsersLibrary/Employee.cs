using System;

namespace UsersLibrary
{
    public class Employee: User, IEquatable<Employee>
    {
        string _position;
        TimeSpan _workExperience;

        public virtual TimeSpan WorkExperience
        {
            get => _workExperience;
            set
            {
                if (value < TimeSpan.Zero)
                    throw new Exception("Work experience can not be less than 0.");
                _workExperience = value;
            }
        }
        
        public string Position
        {
            get => _position;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Position name cannot be empty.");
                _position = value;
            }
        }

        public Employee(string lastName, string firstName, string middleName, DateTime birthDate, TimeSpan workExperience, string position) :
            this(lastName, firstName, birthDate, workExperience, position)
        {
            MiddleName = middleName;
        }

        public Employee(string lastName, string firstName, DateTime birthDate, TimeSpan workExperience, string position) :
            base(lastName, firstName, birthDate)
        {
            WorkExperience = workExperience;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4}\n" +
                "Стаж работы: {5}\nДолжность: {6}\n",
                LastName, FirstName, MiddleName, BirthDate.ToLongDateString(), Age,
                WorkExperience.ToString("%d") + " days", Position);
        }

        public bool Equals(Employee other)
        {
            return Age.Equals(other.Age) &&
                BirthDate.Equals(other.BirthDate) &&
                FirstName.Equals(other.FirstName) &&
                LastName.Equals(other.LastName) &&
                MiddleName.Equals(other.MiddleName) &&
                Position.Equals(other.Position) &&
                WorkExperience.Equals(other.Position);
        }
    }
}
