namespace AssesmentV1.Models
{
    public class Address
    {
        const int DEF_STREETNUM = -1;
        const string DEF_STREET = "No Street Name Given";
        const string DEF_SUBURB = "No Suburb Given";
        const int DEF_POSTCODE = -1;
        const string DEF_STATE = "No State Given";
        
        private int streetNum;
        private string streetName;
        private string suburb;
        private int postCode;
        private string state;
        
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public int PostCode { get; set; }
        public string State { get; set; }

        public Address() : this(DEF_STREETNUM, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
            
        }
        public Address(int streetNum, string streetName, string suburb, int postCode, string state)
        {
            StreetNumber = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            PostCode = postCode;
            State = state;
        }
        
        public override string ToString()
        {
            return $"Street number: {StreetNumber} Street Name: {StreetName}\nSuburb: {Suburb}\nPostcode: {PostCode}\nState: {State}";
        }
    }
}