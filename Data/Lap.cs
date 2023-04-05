namespace BlazorApp.Data {
    public class Lap {
        public Event Event { get; set; }
        public float Time { get; set; }
        public int Penalties { get; set; }
        public int Number { get; set; }
        public Car Car { get; set; }
    }
}