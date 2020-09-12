using System;

namespace BilgeAdam.HelloOOP.App2
{
    internal class ExtendedStudent
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = SetValue(value, nameof(FirstName));
            }
        }
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set
            {
                lastName = SetValue(value, nameof(LastName));
            }
        }
        public DateTime BirthDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

        private string SetValue(string value, string memberName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"{memberName} cannot be null or empty value");
            }
            if (value.Length < 2)
            {
                throw new Exception($"{memberName} cannot be one letter word");
            }
            return value;
        }
    }
}
