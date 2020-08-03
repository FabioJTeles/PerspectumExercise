using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class ReportSettings
    {
        public IList<AnalysisData> analysis_data { get; set; }
        public IList<string> cautions { get; set; }
        public IList<ReferenceRanx> reference_ranges { get; set; }
        public IList<SliceNumber> slice_numbers { get; set; }
        public IList<string> summary_parametric_maps { get; set; }
    }
}
