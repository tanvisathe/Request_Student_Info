using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run == true)
            {
                Console.WriteLine("Welcome to our C# Class. Which student would you like to learn more about?");
                Console.WriteLine("Please enter a number between 1 and 11");
                Console.WriteLine();
                var userResponse = Console.ReadLine();
                //Checking if User responded with a Valid input
                bool validationStatus = UserInputValidation(userResponse);

                if(validationStatus == true)
                {
                    int stuIndexUser = Convert.ToInt32(userResponse); // Converting User-response student index string to int datatype
                    int stuIndex = stuIndexUser - 1; // Subtracting 1 because List index starts from 0 
                    List<Student> ListofStudents = Student.InitializeStudentList();

                    Console.WriteLine("Student: " +stuIndexUser + " is " + ListofStudents[stuIndex].GetFirstName() + " " +ListofStudents[stuIndex].GetLastName());
                    Console.WriteLine();
                    MoreInfo(ListofStudents, stuIndex); // Calls Method "MoreInfo()" for more information about a student
                }
                run = Continue();
            }
        }
        // Method to initialize List of Students
       
        public static void MoreInfo(List<Student> ListofStudents, int stuIndex)
        {
            Console.WriteLine("What would you like to know more about " + ListofStudents[stuIndex].GetFirstName() + "?");
            Console.WriteLine("Enter 'n' for nothing");
            Console.WriteLine("Enter 'hometown' or 'favourite food");
            var request = Console.ReadLine();
            if (request.ToLower() == "hometown")
            {
                Console.WriteLine(ListofStudents[stuIndex].GetFirstName() + " is from " + ListofStudents[stuIndex].GetHomeTown());
                MoreInfo(ListofStudents, stuIndex);
            }

            else if (request.ToLower() == "favourite food")
            {
                Console.WriteLine(ListofStudents[stuIndex].GetFirstName() + "'s favourite food is " + ListofStudents[stuIndex].GetFavFood());
                MoreInfo(ListofStudents, stuIndex);
            }
            else if(request.ToLower() == "n")
            {
                Console.WriteLine("Bye Bye! We are sad to see you leave!");
                
            }
            else
            {
                Console.WriteLine("That data does not exist. Please try again.");
                Console.WriteLine("Enter 'hometown' or 'favourite food'");
            }

        }

        //Method checks for User input validations
        public static bool UserInputValidation(string userResponse)
        {
            int value;
            try
            {
                int number = Convert.ToInt32(userResponse);

                if (string.IsNullOrWhiteSpace(userResponse) || string.IsNullOrWhiteSpace(userResponse))
                {
                    Console.WriteLine("Please enter valid numbers.");
                    return false;
                }
                else if (!Int32.TryParse(userResponse, out value))
                {
                    Console.WriteLine("Please enter Non-Zero and Positive numbers as input and try again.");
                    return false;
                }
                else if (value < 1 || value > 11)
                {
                    Console.WriteLine("That student does not exist. Please enter a number between 1 - 11.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType() }  means  {ex.Message}");
                return false;

            }

        }
        

        public static bool Continue()
        {
            Console.WriteLine("Would you like to know more about our Students?(y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goAhead;
            if (input == "y")
            {
                goAhead = true;

            }
            else if (input == "n")
            {
                goAhead = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, please try again");
                goAhead = Continue();
            }
            return goAhead;
        }
    }
}
