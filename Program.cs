using System;
using AssesmentV1.Models;

namespace AssesmentV1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Person class test");
            Console.WriteLine("")
            Person person1 = new Person(); // create a new Person using no-arg
            Console.WriteLine(person1);
            Console.WriteLine();


            // test Property Accessor Methods
            person1.Name = "Bill";
            person1.Email = "bill@outlook.com";
            person1.PhoneNumber = 123456;
            Console.WriteLine($"Person1 Name:{person1.Name}");
            Console.WriteLine($"Person1 Email:{person1.Email}");
            Console.WriteLine($"Person1 Phone Number:{person1.PhoneNumber}");
            Console.WriteLine(person1);
            Console.WriteLine();

            Person person2 = new Person("Dave", "Dave@gmail.com", 654321);
            Console.WriteLine(person2);
            Console.WriteLine();
            

            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine("Address class test");
            Console.WriteLine();

            Address address1 = new Address();
            Console.WriteLine(address1);
            Console.WriteLine();

            // test Property Accessor Methods
            address1.StreetNumber = 123;
            address1.StreetName = "Donald Street";
            address1.Suburb = "Whitchurch";
            address1.PostCode = 6059;
            address1.State = "SA";

            Console.WriteLine($"Address1 Street Number: {address1.StreetNumber}");
            Console.WriteLine($"Address1 Street Name: {address1.StreetName}");
            Console.WriteLine($"Address1 Suburb: {address1.Suburb}");
            Console.WriteLine($"Address1 Post Code: {address1.PostCode}");
            Console.WriteLine($"Address1 State: {address1.State}");
            Console.WriteLine();
            Console.WriteLine(address1);
            Console.WriteLine();

            Address address2 = new Address(321, "Lime Road", "Rose", 54321, "WA");
            Console.WriteLine(address2);
            Console.WriteLine();

            Person person3 = new Person("Ellie", "Ellie@gmail.com", 001100, address2);
            Console.WriteLine(person3);
            
            Console.WriteLine("----------------------------------------------------------------");
            

            Console.WriteLine("Student class test");
            Console.WriteLine();

            Student student1 = new Student(); // create new Student using no-arg
            Console.WriteLine("Student1:");
            Console.WriteLine(student1);
            Console.WriteLine();
            
            // test Property Accessor Methods
            student1.StudentId = "S200";
            student1.DateRegistered = "14-06-2022";
            student1.Program = "IT";
            Console.WriteLine(student1);
            Console.WriteLine();

            Address address3 = new Address(39, "Gordon Street", "Glenelg", 54321, "SA");
            Person person4 = new Person("Sam", "Sam@gmail.com", 8991100, address3);
            //Student student2 = new Student(person4, "S200", "IT", "14-06-2022");
            //Console.WriteLine(student2);
            
            Console.WriteLine("----------------------------------------------------------------");
            
            Console.WriteLine("Enrollment and subject class test");
            Console.WriteLine();

            // Test Enrollment creation
            Enrollment enrollment1 = new Enrollment();
            Console.WriteLine(enrollment1);
            Console.WriteLine();
            
            // Test Subject creation
            Subject subject1 = new Subject();
            Console.WriteLine("Subject1 (default):");
            Console.WriteLine(subject1);
            Console.WriteLine();
            
            // Test Enrollment property setters
            enrollment1.DateEnrolled = "01-09-2022";
            enrollment1.Grade = "A";
            enrollment1.Semester = "Fall 2022";
            enrollment1.Subject = subject1;
            Console.WriteLine("Enrollment1 (after setting properties):");
            Console.WriteLine(enrollment1);
            Console.WriteLine();
            
            // Test Enrollment property setters
            enrollment1.DateEnrolled = "01-09-2022";
            enrollment1.Grade = "A";
            enrollment1.Semester = "Fall 2022";
            enrollment1.Subject = subject1;
            Console.WriteLine("Enrollment1 (after setting properties):");
            Console.WriteLine(enrollment1);
            Console.WriteLine();
            
            // Test Subject property setters
            subject1.SubjectCode = "CS101";
            subject1.SubjectName = "Introduction to Computer Science";
            subject1.Cost = 150.00;
            Console.WriteLine("Subject1 (after setting properties):");
            Console.WriteLine(subject1);
            Console.WriteLine();
            
            Subject subject2 = new Subject("MATH201", "Calculus I", 200.00);
            Console.WriteLine("Subject2:");
            Console.WriteLine(subject2);
            Console.WriteLine();
            
            Enrollment enrollment2 = new Enrollment("15-01-2023", "B+", "Spring 2023", subject2);
            Console.WriteLine("Enrollment2:");
            Console.WriteLine(enrollment2);
            Console.WriteLine();
            
            Address address4 = new Address(38, "Gordonston Street", "Glenelg", 54321, "SA");
            Person person7 = new Person("Jane", "Jane@gmail.com", 091100, address4);
            Student student4 = new Student(person7, "S200", "IT", "14-06-2022", enrollment2);
            Console.WriteLine(student4);
            Console.WriteLine();
            
            

            Console.WriteLine("----------------------------------------------------------------");
            
            Console.WriteLine("Equality Tests for Student Class");
            Console.WriteLine();



            // Create two students with the same StudentId
            Student student5 = new Student { StudentId = "S001", Name = "John Doe", Email = "john@example.com" };
            Student student6 = new Student { StudentId = "S001", Name = "John Doe", Email = "john.different@example.com"};

            // Create another student with a different StudentId
            Student student3 = new Student { StudentId = "S002", Name = "Jane Doe", Email = "jane@example.com"};

            // Test Equals method
            Console.WriteLine($"student1.Equals(student2): {student1.Equals(student5)}"); // Should be True
            Console.WriteLine($"student1.Equals(student3): {student1.Equals(student6)}"); // Should be False

            // Test '==' operator
            Console.WriteLine($"student1 == student2: {student1 == student5}"); // Should be True
            Console.WriteLine($"student1 == student3: {student1 == student6}"); // Should be False

            // Test '!=' operator
            Console.WriteLine($"student1 != student2: {student1 != student5}"); // Should be False
            Console.WriteLine($"student1 != student3: {student1 != student6}"); // Should be True

            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();












        }
    }
}