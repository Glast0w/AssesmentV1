namespace AssesmentV1.Models
{
    public class Enrollment
    {
        const string DEF_DateEnrolled = "Not enrolled";
        const string DEF_GRADE = "No Grade set";
        const string DEF_SEMESTER = "Not Set";

        private string dateEnrolled;
        private string grade;
        private string semester;
        
        
        public string DateEnrolled {  get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }
        
        public Enrollment() : this(DEF_DateEnrolled, DEF_GRADE, DEF_SEMESTER)
        {
            
        }
        
        public Enrollment(string dateEnrolled, string grade, string semester) : this(dateEnrolled, grade, semester, new Subject())
        {
            // DateEnrolled = dateEnrolled;
            // Grade = grade;
            // /Semester = semester;
        }
        
        public Enrollment(string dateEnrolled, string grade, string semester,Subject subject )
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }
        
        public override string ToString()
        {
            return $"Date Enrolled: {DateEnrolled}, Grade: {Grade}, Semester: {Semester}, \nSubject {Subject}"; 
        }
        
        
        
        
        
        


    }
}