namespace BlazorApp.Data {
    public class Driver {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public List<Car> Cars { get; set; }
        public List<Event> Events { get; set; }
        public List<Lap> Laps { get; set; }   
    }
}