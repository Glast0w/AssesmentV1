namespace AssesmentV1.Models
{
    public class Subject
    {
        // Default values properties
        const string DEF_SUBJECT_CODE = "No code provided";
        const string DEF_SUBJECT_NAME = "No name provided";
        const double DEF_COST = 0.0;
        
        // Private Properties 
        private string subjectCode;
        private string subjectName;
        private double cost;
        
        // Public Properties
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Initializes a new instance of the Subject class with default values for SubjectCode, SubjectName, and Cost.
        /// </summary>
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
            
        }
        
        /// <summary>
        /// Initializes a new instance of the Subject class with specified values for SubjectCode, SubjectName, and Cost.
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }
        
        /// <summary>
        /// Returns a string that represents the current Subject, formatted.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: {Cost}";
        }
        
        
    }
}