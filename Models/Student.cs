namespace AssesmentV1.Models
{
    public class Student : Person
    {
        // Default values properties
        const string DEF_STUDENTID = "No ID set";
        const string DEF_PROGRAM = "No Program set";
        const string DEF_REGISTERED = "Not Registered";

        // Private Properties 
        private string studentId;
        private string program;
        private string dateRegistered;
        
        // Public Properties
        public string StudentId { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the Student class with default values for StudentId, Program, and DateRegistered.
        /// </summary>
        public Student() : this(DEF_STUDENTID, DEF_PROGRAM, DEF_REGISTERED)
        {

        }

        /// <summary>
        /// Initializes a new instance of the Student class with specified values for StudentId, Program, and DateRegistered, and a default Enrollment.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        public Student(string studentId, string program, string dateRegistered) : this(studentId, program, dateRegistered, new Enrollment())
        {

        }
        
        /// <summary>
        /// Initializes a new instance of the Student class with specified values for StudentId, Program, DateRegistered, and Enrollment.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        public Student(string studentId, string program, string dateRegistered, Enrollment enrollment) 
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }
        
        /// <summary>
        /// Initializes a new instance of the Student class from an existing Person object, with specified values for StudentId, Program, DateRegistered, and Enrollment.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="studentId"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        public Student(Person person, string studentId, string program, string dateRegistered, Enrollment enrollment)
            : base(person.Name, person.Email, person.PhoneNumber, person.personAddress) 
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }


        /// <summary>
        /// Determines whether the specified object is equal to the current student, based on StudentId.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            var student = obj as Student;
            return student != null && student.StudentId == this.StudentId;
        }
        
        /// <summary>
        /// Serves as the default hash function, using the StudentId property.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.StudentId.GetHashCode();
        }

        /// <summary>
        /// Compares two Student instances for equality based on the StudentId property.
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static bool operator ==(Student student1, Student student2)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(student1, student2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (student1 is null || student2 is null)
            {
                return false;
            }

            // Return true if their IDs are equal
            return student1.StudentId == student2.StudentId;
        }

        /// <summary>
        /// Compares two Student instances for inequality based on the StudentId property.
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }


        /// <summary>
        /// Returns a string that represents the current Student object,
        /// including Name, Email, PhoneNumber, StudentId, Program, DateRegistered, and Enrollment details.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() +
                   $", \nStudentId: {StudentId}, Program: {Program}, DateRegistered: {DateRegistered}, \nEnrollment: {StudentEnrollment}";
        }

    }
}