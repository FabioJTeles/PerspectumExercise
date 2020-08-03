using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class QualityControl
    {
        public CentreFrequencyResults centre_frequency_results { get; set; }
        public string distortion_correction_status { get; set; }
        public string dynamic_range_status { get; set; }
        public IList<string> parametric_map_ids { get; set; }
        public string rr_interval_status { get; set; }
        public IList<string> series_numbers { get; set; }
        public string shim_status { get; set; }
        public string slice_location { get; set; }
        public IList<TagValueResult> tag_value_results { get; set; }
    }
}
