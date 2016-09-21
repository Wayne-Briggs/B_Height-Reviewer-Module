using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Height_Reviewer_Module.Model
{
    class ExcelData : IExcelData
    {
        //Data
        public string tSheetFilePath { get; set; }
        public int tSheetNum { get; set; }
        public string cSheetFilePath { get; set; }
        public int cSheetNum { get; set; }
        public string oSheetFilePath { get; set; }

        public List<string> cSheetFilePaths = new List<string>();
        public List<string> cameraList = new List<string>();
        public List<string> reviewerList = new List<string>();

        public event EventHandler<EventArgs> getFilePath;
        public event EventHandler<EventArgs> getTrackingSheet;
        public event EventHandler<EventArgs> getCameraSheet;

        //Business logic
    }
}
