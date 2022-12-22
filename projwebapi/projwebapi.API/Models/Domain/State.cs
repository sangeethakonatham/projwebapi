namespace projwebapi.API.Models.Domain
{
    public class State
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Double ZipCode { get; set; }
        public long Population { get; set; }
        public Guid CountryId { get; set; }
        //Navigation Property
        public Country Country{ get; set; }
    }
}
