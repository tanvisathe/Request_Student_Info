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

        //Initialize Students
        public static List<Student> InitializeStudentList()
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Tanvi", "Sathe", "India", "Biryani"));
            studentList.Add(new Student("Molly", "Guthrie", "RockFord, MI", "Noodles"));
            studentList.Add(new Student("Michelle", "Polo", "Ecuador", "Spaghetti"));
            studentList.Add(new Student("Rebecca", "Allard", "Charlevoix,MI", "Pizza"));
            studentList.Add(new Student("Brianna", "Jael", "Fairfield, CA", "Gumbo"));
            studentList.Add(new Student("Tammy", "Cole", "GrandRapids,MI", "Maru Sushi"));
            studentList.Add(new Student("Lauren", "Babcock", "Plainwell,MI", "Cheeseburgers"));
            studentList.Add(new Student("Karina", "Lopez", "Holland, MI", "Tacos"));
            studentList.Add(new Student("Tommy", "Waalkes", "Raleigh,NC", "Indian Red Curries"));
            studentList.Add(new Student("Lisa", "Dewey", "Los Angeles,CA", "Mushroom Masala Dosa"));
            studentList.Add(new Student("Jonaca", "Hudson", "Lansing,MI", "Sushi"));


            return studentList;
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
