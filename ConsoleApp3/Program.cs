using System;
using System.Collections.Generic;


namespace AttendeesList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<attendee> theList = new List<attendee>();
            
            int userInput = 0;

            do
            {
                userInput = Menu();

                if (userInput == 1)
                {
                 
                    foreach (attendee a in theList)
                    {
                        a.PrintAttendee();  
                    }
                }
                else if (userInput == 2)
                {
                   
                    theList.Add(WriteAttendee());
                    Console.WriteLine("Attendee added successfully!\n");
                }
                else if (userInput != 3)
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                }

            } while (userInput != 3);
        }

  
        public static int Menu()
        {
            Console.WriteLine("Conference Attendees \n");
            Console.WriteLine("1 - Print all attendees");
            Console.WriteLine("2 - Write attendee");
            Console.WriteLine("3 - Exit \n");
            Console.WriteLine("Enter a value:");

       
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

      
        public static attendee WriteAttendee()
        {
           
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Company: ");
            string company = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            return new attendee(firstName, lastName, email, company, state);
        }
    }
}
