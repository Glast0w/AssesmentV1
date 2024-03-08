namespace AssesmentV1.Models
{
    public class Enrollment
    {
        // Default values properties
        const string DEF_DateEnrolled = "Not enrolled";
        const string DEF_GRADE = "No Grade set";
        const string DEF_SEMESTER = "Not Set";

        // Private Properties 
        private string dateEnrolled;
        private string grade;
        private string semester;
        
        // Public Properties
        public string DateEnrolled {  get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the Enrollment class with default values for DateEnrolled, Grade, and Semester.
        /// </summary>
        public Enrollment() : this(DEF_DateEnrolled, DEF_GRADE, DEF_SEMESTER)
        {
            
        }
        
        /// <summary>
        /// Initializes a new instance of the Enrollment class with specified values for DateEnrolled, Grade, Semester, and a default Subject.
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        public Enrollment(string dateEnrolled, string grade, string semester) : this(dateEnrolled, grade, semester, new Subject())
        {
            // DateEnrolled = dateEnrolled;
            // Grade = grade;
            // /Semester = semester;
        }
        
        /// <summary>
        /// Initializes a new instance of the Enrollment class with specified values for DateEnrolled, Grade, Semester, and Subject.
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        /// <param name="subject"></param>
        public Enrollment(string dateEnrolled, string grade, string semester,Subject subject )
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }
        
        /// <summary>
        /// Returns a string that represents the current Enrollment object, formatted
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Date Enrolled: {DateEnrolled}, Grade: {Grade}, Semester: {Semester}, \nSubject {Subject}"; 
        }
        
        
        
        
        
        


    }
}