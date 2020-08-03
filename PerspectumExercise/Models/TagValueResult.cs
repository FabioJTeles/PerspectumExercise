using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class TagValueResult
    {
        public string error_message { get; set; }
        public string expected_values { get; set; }
        public IList<string> read_data { get; set; }
        public string status { get; set; }
    }
}
