using B_Height_Reviewer_Module.Model;
using B_Height_Reviewer_Module.Presenters;
using B_Height_Reviewer_Module.View;
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
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            presenter = new Presenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getFilePath(this, EventArgs.Empty);
                //presenter.onBtnClick();
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
