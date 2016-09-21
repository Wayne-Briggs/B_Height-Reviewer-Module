using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Height_Reviewer_Module.Models
{
    public class Model
    {
        //Data
        public static string tSheetFilePath { get; set; }
        public static int tSheetNum { get; set; }
        public static string cSheetFilePath { get; set; }
        public static int cSheetNum { get; set; }
        public static string oSheetFilePath { get; set; }

        public static List<string> cSheetFilePaths = new List<string>();
        public static List<string> cameraList = new List<string>();
        public static List<string> reviewerList = new List<string>();

        //Business logic
    }
}
