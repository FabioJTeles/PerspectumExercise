using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace PerspectumExercise.Helper
{
    public  class DeserializeHelper
    {
        public static t Deserialize<t>(Stream fileStream)
        {
            t outputObject;
            using (StreamReader r = new StreamReader(fileStream))
            {
                string json = r.ReadToEnd();
                outputObject = JsonConvert.DeserializeObject<t>(json);
            }
            return outputObject;
        }
    }
}