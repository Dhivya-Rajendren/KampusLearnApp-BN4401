namespace KampusLearnApp.Models
{
    public class Batch
    {
        //Auto implemented Properties
        public string BatchNumber { get; set; }

        public int CourseID { get; set; }
        public int TrainerID { get; set; }

        public List<int> StudentIds { get; set; }

        public DateTime BatchStartDate { get; set; }
        public string BatchTiming { get; set; }
    }
}
