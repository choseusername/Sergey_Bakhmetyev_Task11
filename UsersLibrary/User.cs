using System;
namespace UsersLibrary
{
    public class User
    {
        string _firstName,
                       _middleName,
                       _lastName;
        DateTime _birthDate;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("First name cannot be empty.");
                _firstName = value;
            }
        }

        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value;
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Last name cannot be empty.");
                _lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (_birthDate > value)
                    throw new Exception("Date of birth cannot be later today.");
                _birthDate = value;
            }
        }

        public int Age => CalculateAge(BirthDate);

        public User(string lastName, string firstName, string middleName, DateTime birthDate)
            : this(lastName, lastName, birthDate)
        {
            MiddleName = middleName;
        }

        public User(string lastName, string firstName, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4}\n",
                LastName, FirstName, MiddleName, BirthDate.ToLongDateString(), Age);
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate > today.AddYears(-age)) age--;
            return age;
        }

        public bool Equals(User other)
        {
            throw new NotImplementedException();
        }
    }
}
