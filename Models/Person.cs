namespace AssesmentV1.Models
{
    public class Person
    {
        // Constants for default values
        private const string DEF_NAME = "No name provided";
        private const string DEF_EMAIL = "No email provided";
        private const int DEF_NUMBER = -1;

        // Private Properties
        private string name;
        private string email;
        private int phoneNumber;

        // Public Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        
        public Address personAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the Person class with default values for Name, Email, and PhoneNumber.
        /// </summary>
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_NUMBER)
        {

        }
        
        public Person(string name, string email, int phoneNumber) : this(name, email, phoneNumber, new Address())
        {

        }

        /// <summary>
        /// Initializes a new instance of the Person class with specified values for Name, Email, PhoneNumber, and Address.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public Person(string name, string email, int phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            personAddress = address;
        }
        
        
        /// <summary>
        /// Returns a string that represents the current Person, Address formatted
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, \nAddress: {personAddress}";
        }
    }
}