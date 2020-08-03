using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class Analysis
    {
        public string analyst { get; set; }
        public string datetime { get; set; }
        public IList<string> location { get; set; }
        public string platform { get; set; }
    }
}
