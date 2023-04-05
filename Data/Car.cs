namespace BlazorApp.Data {
    public class Car {
        public int Number { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Class { get; set; }
        public float PaxFactor { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Lap> Laps { get; set; }
        public List<Event> Events { get; set; }
    }
}