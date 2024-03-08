namespace AssesmentV1.Models
{
    public class Address
    {
        // Default values properties
        const int DEF_STREETNUM = -1;
        const string DEF_STREET = "No Street Name Given";
        const string DEF_SUBURB = "No Suburb Given";
        const int DEF_POSTCODE = -1;
        const string DEF_STATE = "No State Given";
        
        // Private Properties 
        private int streetNum;
        private string streetName;
        private string suburb;
        private int postCode;
        private string state;
        
        // Public Properties
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public int PostCode { get; set; }
        public string State { get; set; }

        /// <summary>
        ///  Initializes a new instance of the Address class with default values.
        /// </summary>
        public Address() : this(DEF_STREETNUM, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
            
        }
        
        /// <summary>
        /// Initializes a new instance of the Address class with custom values for each property.
        /// </summary>
        /// <param name="streetNum"></param>
        /// <param name="streetName"></param>
        /// <param name="suburb"></param>
        /// <param name="postCode"></param>
        /// <param name="state"></param>
        public Address(int streetNum, string streetName, string suburb, int postCode, string state)
        {
            StreetNumber = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            PostCode = postCode;
            State = state;
        }
        
        /// <summary>
        /// Returns a string that represents the current address, formatted.
        /// <returns></returns>        
        public override string ToString()
        {
            return $"Street number: {StreetNumber} Street Name: {StreetName}\nSuburb: {Suburb}\nPostcode: {PostCode}\nState: {State}";
        }
    }
}