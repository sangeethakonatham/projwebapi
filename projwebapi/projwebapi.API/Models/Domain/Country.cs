namespace projwebapi.API.Models.Domain
{
    public class Country
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Double ZipCode { get; set; }
        public long Population { get; set; }
       

        //Navigation Property
        public IEnumerable<State> States{ get; set; }//one country multiple states which is true


    }
}
