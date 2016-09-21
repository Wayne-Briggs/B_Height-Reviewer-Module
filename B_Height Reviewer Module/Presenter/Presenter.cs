using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Height_Reviewer_Module.Model;
using System.Windows.Forms;

namespace B_Height_Reviewer_Module.Presenters
{
    public class Presenter
    {
        private readonly IExcelData view;
        private List<ExcelData> exceldata;

        public Presenter(IExcelData view)
        {
            this.view = view;
            Initialize();
        }

        private void Initialize()
        {
            exceldata = new List<ExcelData>();
            view.getFilePath += GetFilePath;
            view.getCameraSheet += GetTrackingSheet;
            view.getCameraSheet += GetCameraSheet;
        }

        private void GetFilePath(object sender, EventArgs e)
        {
            //Opens file search, lets user choose file, then retrieves filepath.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XLS/XLSX Files (*.xls; *.xlsx)|*.xls; *.xlsx";

            //Multiselect option for selecting mutiple camera sheets at once.
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //switch (whichFile)
                //{
                //    case "Tracking":
                //        Data.tSheetFilePath = ofd.FileName;
                //        Data.tSheetNum = 3;
                //        break;

                //    case "Camera":
                //        // Read the files
                //        foreach (String file in ofd.FileNames)
                //        {
                //            Data.cSheetFilePaths.Add(file);
                //        }
                //        Data.cSheetNum = 1;
                //        break;

                //    case "Observation":
                //        Data.oSheetFilePath = ofd.FileName;
                //        break;
                //}
            }
        }

        private void GetTrackingSheet(object sender, EventArgs e)
        {
            
        }

        private void GetCameraSheet(object sender, EventArgs e)
        {

        }
    }
}
