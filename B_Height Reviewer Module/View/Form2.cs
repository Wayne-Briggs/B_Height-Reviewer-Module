using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Height_Reviewer_Module_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFilePath getfile = new GetFilePath();
            getfile.selectFile("Camera");
            ReadExcelFile readexcel = new ReadExcelFile();
            readexcel.readExcel(Data.cSheetFilePaths[0], Data.cSheetNum, "Camera");
            this.Close();
            Application.Exit();
        }
    }
}
