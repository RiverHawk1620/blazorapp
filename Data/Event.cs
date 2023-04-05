namespace BlazorApp.Data {
    public class Event {
        public int Name { get; set; }
        public int Season { get; set; }
        //TODO: Should this be a code/valid value list?
        public string Type { get; set; }
        public int Number { get; set; }
        public List<string> HostClubs { get; set; }
        public string Location { get; set; }
        public DateTime EventDate { get; set; }
    }
}