namespace AssesmentV1.Models
{
    public class Subject
    {
        const string DEF_SUBJECT_CODE = "No code provided";
        const string DEF_SUBJECT_NAME = "No name provided";
        const double DEF_COST = 0.0;

        private string subjectCode;
        private string subjectName;
        private double cost;
        
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {
            
        }
        
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }
        
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: {Cost}";
        }
        
        
    }
}