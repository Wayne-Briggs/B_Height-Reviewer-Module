using B_Height_Reviewer_Module.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Height_Reviewer_Module
{
    public partial class Form1 : Form
    {
        public Presenter presenter { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.onBtnClick();
                //GetFilePath getfile = new GetFilePath();
                //getfile.selectFile("Tracking");
                //ReadExcelFile readexcel = new ReadExcelFile();
                //readexcel.readExcel(Data.tSheetFilePath, Data.tSheetNum, "Tracking");
            }
            catch(Exception)
            {
                MessageBox.Show("There was an error, please try again");
            }
            
            //this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }
    }
}
