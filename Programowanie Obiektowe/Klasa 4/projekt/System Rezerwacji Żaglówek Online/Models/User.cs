namespace System_Rezerwacji_Zaglowek_Online.Models
{
    public class User
    {
        public User(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (Email: {Email}, Tel: {PhoneNumber})";
        }
    }
}