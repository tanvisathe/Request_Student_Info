using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Student
    {
        private string FirstName;
        private string LastName;
        private string Hometown;
        private string Food;

        public Student(string firstname, string lastname, string hometown, string food)
        {
            FirstName = firstname;
            LastName = lastname;
            Hometown = hometown;
            Food = food;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetHomeTown()
        {
            return Hometown;
        }

        public string GetFavFood()
        {
            return Food;
        }

    }
}
