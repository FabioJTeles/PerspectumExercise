namespace PerspectumExercise.Models
{
    public class RoiSummary
    {
        public double lower_quartile { get; set; }
        public double mean { get; set; }
        public double median { get; set; }
        public int number_of_rois { get; set; }
        public string type { get; set; }
        public double upper_quartile { get; set; }
        public ReportedValues reported_values { get; set; }
    }
}
