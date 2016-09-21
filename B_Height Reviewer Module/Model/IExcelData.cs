using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Height_Reviewer_Module.Model
{
    public interface IExcelData
    {
        //Data
        string tSheetFilePath { get; set; }
        int tSheetNum { get; set; }
        string cSheetFilePath { get; set; }
        int cSheetNum { get; set; }
        string oSheetFilePath { get; set; }


        event EventHandler<EventArgs> getFilePath;
        event EventHandler<EventArgs> getTrackingSheet;
        event EventHandler<EventArgs> getCameraSheet;
    }
}
