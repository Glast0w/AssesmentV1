namespace AssesmentV1.Models
{
    public class Student : Person
    {
        const string DEF_STUDENTID = "No ID set";
        const string DEF_PROGRAM = "No Program set";
        const string DEF_REGISTERED = "Not Registered";

        private string studentId;
        private string program;
        private string dateRegistered;
        
        public string StudentId { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }
        
        public Enrollment StudentEnrollment { get; set; }
        
        public Student() : this(DEF_STUDENTID, DEF_PROGRAM, DEF_REGISTERED)
        {

        }

        public Student(string studentId, string program, string dateRegistered) : this(studentId, program, dateRegistered, new Enrollment())
        {

        }
        
        public Student(string studentId, string program, string dateRegistered, Enrollment enrollment) 
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }
        
        public Student(Person person, string studentId, string program, string dateRegistered, Enrollment enrollment)
            : base(person.Name, person.Email, person.PhoneNumber, person.personAddress) 
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }



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
        public override int GetHashCode()
        {
            return this.StudentId.GetHashCode();
        }


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

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }


        public override string ToString()
        {
            return base.ToString() +
                   $", \nStudentId: {StudentId}, Program: {Program}, DateRegistered: {DateRegistered}, \nEnrollment: {StudentEnrollment}";
        }

    }
}