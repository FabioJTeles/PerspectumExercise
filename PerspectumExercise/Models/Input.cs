using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class Input
    {
        public ScanData scan_data { get; set; }
        public IList<string> input_series { get; set; }
        public IList<SeriesInformation> series_information { get; set; }
        public IList<InputMapping> input_mapping { get; set; }
        public IList<RoiPlacement> roi_placement { get; set; }
    }
}
