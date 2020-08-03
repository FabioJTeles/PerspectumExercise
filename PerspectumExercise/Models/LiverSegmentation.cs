namespace PerspectumExercise.Models
{
    public class LiverSegmentation
    {
        public double area { get; set; }
        public double lower_quartile { get; set; }
        public double mean { get; set; }
        public double median { get; set; }
        public string type { get; set; }
        public double upper_quartile { get; set; }
        public ReportedValues reported_values { get; set; }
    }
}
