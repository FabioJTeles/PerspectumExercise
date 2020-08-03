using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class QualityChecks
    {
        public IList<object> image_quality_comments { get; set; }
        public IList<QualityControl> quality_control { get; set; }
    }
}
