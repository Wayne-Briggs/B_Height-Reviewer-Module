using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Height_Reviewer_Module.Models;


namespace B_Height_Reviewer_Module.Presenters
{
    public class Presenter
    {
        private Model model;
        private Form1 view1;
        private Form2 view2;

        public Presenter(Model model, Form1 view1, Form2 view2)
        {
            this.model = model;
            this.view1 = view1;
            this.view2 = view2;

            view1.presenter = this;
        }

        public void onBtnClick()
        {
            model.getFilePath();
        }
    }
}
