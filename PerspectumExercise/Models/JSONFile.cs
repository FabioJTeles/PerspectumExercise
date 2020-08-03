using System.Collections.Generic;

namespace PerspectumExercise.Models
{
    public class JSONFile
    {
        public Analysis analysis { get; set; }
        public string format { get; set; }
        public IList<Input> inputs { get; set; }
        public IList<Outputs> outputs { get; set; }
        public Product product { get; set; }
        public string version { get; set; }
    }
}
