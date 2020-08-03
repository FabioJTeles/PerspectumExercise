using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using PerspectumExercise.Models;
using PerspectumExercise.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerspectumExercise.Controllers
{
    public class MainController : Controller
    {
        private JSONFile DataFile {
            get {
                return TempData.Peek("file") as JSONFile;
            }
            set
            {
                TempData["file"] = value;
            } 
        }
        public IndexViewModel IndexViewModel
        {
            get
            {
                return TempData.Peek("IndexViewModel") as IndexViewModel;
            }
            set
            {
                TempData["IndexViewModel"] = value;
            }
        }
        public ActionResult Index()
        {
            GetParametricMaps();

            return View("~/Views/Main.cshtml", IndexViewModel);
        }
        [HttpGet]
        public ActionResult GetRoiSummary(string selectedType)
        {
            var roiSummaryList = new List<RoiSummary>();
            roiSummaryList = DataFile.outputs.Select(x => x.roi_summary).FirstOrDefault().Where(x => x.type == selectedType).ToList();

            return PartialView("~/Views/Tables/RoiSummary.cshtml", roiSummaryList);
        }
        //to get form values, submitted by user
        [HttpGet]
        public ActionResult GetRoiSliceSummary(string selectedType)
        {
            var roiSliceSummaryList = new List<RoiSliceSummary>();
            var selectedParametricMap = IndexViewModel.ParametricMaps.Where(x => x.type == selectedType);
            roiSliceSummaryList = DataFile.outputs.Select(x => x.roi_slice_summary).FirstOrDefault(x => x != null).Where(x => selectedParametricMap.Any(y => y.parametric_map_id == x.parametric_map_id)).ToList();

            return PartialView("~/Views/Tables/RoiSliceSummary.cshtml", roiSliceSummaryList);
        }
        //to get form values, submitted by user
        [HttpGet]
        public ActionResult GetLiverSegmentation(string selectedType)
        {
            var roiLiverSegmentationList = new List<LiverSegmentation>();
            roiLiverSegmentationList = DataFile.outputs.Select(x => x.liver_segmentation).FirstOrDefault(x => x != null).Where(x => x.type == selectedType).ToList();

            return PartialView("~/Views/Tables/LiverSegmentation.cshtml", roiLiverSegmentationList);
        }
        //to get form values, submitted by user
        [HttpGet]
        public ActionResult GetLiverSliceStatistics(string selectedType)
        {
            var roiLiverSliceStatisticList = new List<LiverSliceStatistic>();
            var selectedParametricMap = IndexViewModel.ParametricMaps.Where(x => x.type == selectedType);

            roiLiverSliceStatisticList = DataFile.outputs.Select(x => x.liver_slice_statistics).FirstOrDefault(x => x != null).Where(x => selectedParametricMap.Any(y => y.parametric_map_id == x.parametric_map_id)).ToList();


            return PartialView("~/Views/Tables/LiverSliceStatistics.cshtml", roiLiverSliceStatisticList);
        }
        private void GetParametricMaps()
        {
            var outputModel = new IndexViewModel();
            outputModel.AnalysisTypes = new List<SelectListItem>();
            outputModel.ParametricMaps = new List<ParametricMap>();
            var inputmappings = DataFile.inputs.Select(x => x.input_mapping).FirstOrDefault(x => x != null);
            var paramtypes = inputmappings.Select(x => x.parametric_maps);

            foreach (var parametricMapItem in paramtypes)
            {
                outputModel.AnalysisTypes.AddRange(
                    parametricMapItem.Select(a => new SelectListItem
                    {
                        Text = a.type, // name to show in html dropdown
                        Value = a.type // value of html dropdown
                    }));

                outputModel.ParametricMaps.AddRange(parametricMapItem);
            }
            outputModel.ParametricMaps = outputModel.ParametricMaps;
            outputModel.AnalysisTypes = outputModel.AnalysisTypes.DistinctBy(x => x.Value).OrderBy(x => x.Text).ToList();
            IndexViewModel = outputModel;
            TempData["IndexViewModel"] = IndexViewModel;
        }
    }
}