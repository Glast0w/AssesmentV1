namespace AssesmentV1.Models
{
    public class Person
    {
        // Constants for default values
        private const string DEF_NAME = "No name provided";
        private const string DEF_EMAIL = "No email provided";
        private const int DEF_NUMBER = -1;

        private string name;
        private string email;
        private int phoneNumber;

        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        
        public Address personAddress { get; set; }

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_NUMBER)
        {

        }



        public Person(string name, string email, int phoneNumber) : this(name, email, phoneNumber, new Address())
        {

        }

        public Person(string name, string email, int phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            personAddress = address;
        }
        
        

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, \nAddress: {personAddress}";
        }
    }
}