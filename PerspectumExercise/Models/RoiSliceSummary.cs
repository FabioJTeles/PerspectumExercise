namespace PerspectumExercise.Models
{
    public class RoiSliceSummary
    {
        public double lower_quartile { get; set; }
        public double mean { get; set; }
        public double median { get; set; }
        public int number_of_rois { get; set; }
        public string parametric_map_id { get; set; }
        public double upper_quartile { get; set; }
    }
}
