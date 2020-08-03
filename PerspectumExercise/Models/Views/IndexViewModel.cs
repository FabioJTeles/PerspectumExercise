using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerspectumExercise.Models.Views
{
    public class IndexViewModel
    {
        public string SelectedType { get; set; }
        public List<SelectListItem> AnalysisTypes { get; set; }
        public List<ParametricMap> ParametricMaps { get; set; }
        public string teste { get; set; }

    }
}