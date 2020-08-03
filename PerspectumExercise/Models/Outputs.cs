using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class Outputs
    {
        public IList<RoiSummary> roi_summary { get; set; }
        public IList<RoiStatistic> roi_statistics { get; set; }
        public IList<RoiSliceSummary> roi_slice_summary { get; set; }
        public IList<LiverSegmentation> liver_segmentation { get; set; }
        public IList<LiverSliceStatistic> liver_slice_statistics { get; set; }
        public QualityChecks quality_checks { get; set; }
        public ReportSettings report_settings { get; set; }
    }
}
