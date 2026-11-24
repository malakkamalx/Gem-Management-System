namespace Gem_Management_System.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
