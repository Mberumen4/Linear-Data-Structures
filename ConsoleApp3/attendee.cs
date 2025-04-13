namespace AttendeesList
{
    class attendee
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string State { get; set; }

    
        public attendee(string firstName, string lastName, string email, string company, string state)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Company = company;
            State = state;
        }

       
        public void PrintAttendee()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine(); 
        }
    }
}