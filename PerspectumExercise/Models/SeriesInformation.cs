using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class SeriesInformation
    {
        public IList<double> echo_times { get; set; }
        public IList<IList<double>> image_orientation_patient { get; set; }
        public IList<double> image_position_patient { get; set; }
        public IList<string> parametric_map_ids { get; set; }
        public string series_description { get; set; }
        public IList<string> series_instance_uids { get; set; }
        public IList<string> series_numbers { get; set; }
        public string slice_location { get; set; }
        public IList<double> inversion_times { get; set; }
        public IList<double> rr_intervals { get; set; }
    }
}
