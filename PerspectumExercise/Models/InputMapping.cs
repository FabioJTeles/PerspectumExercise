using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class InputMapping
    {
        public IList<ParametricMap> parametric_maps { get; set; }
        public IList<string> series_numbers { get; set; }
    }
}
