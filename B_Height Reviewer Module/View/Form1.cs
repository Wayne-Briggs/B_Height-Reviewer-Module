﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFilePath getfile = new GetFilePath();
            getfile.selectFile("Tracking");
            ReadExcelFile readexcel = new ReadExcelFile();
            readexcel.readExcel(Data.tSheetFilePath, Data.tSheetNum, "Tracking");
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
