using B_Height_Reviewer_Module.Models;
using B_Height_Reviewer_Module.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Height_Reviewer_Module
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // model
            Model model = new Model();

            // view2
            Form1 view1 = new Form1();
            Form2 view2 = new Form2();

            // presenter
            Presenter presenter = new Presenter(model, view1, view2);

            Application.Run(view1);
        }
    }
}
