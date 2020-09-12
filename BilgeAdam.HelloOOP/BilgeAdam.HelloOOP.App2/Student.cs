using System;

namespace BilgeAdam.HelloOOP.App2
{
    class Student
    {
        private string lastName;
        public string FirstName { get; set; }
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set { lastName = value; }
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
    }
}
