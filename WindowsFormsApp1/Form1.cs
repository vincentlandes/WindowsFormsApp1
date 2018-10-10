using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        public string StartStaion
        {
            get {return startStation.SelectedValue.ToString();}
        }

        public string EndStation
        {
            get { return startStation.SelectedValue.ToString(); }
        }

        public string WayType 
        {
            get { return wayType.SelectedValue.ToString(); }
        }

        public string Discount
        {
            get { return discountType.SelectedValue.ToString(); }
        }

        public string ClassType
        {
            get { return classType.SelectedValue.ToString(); }
        }

        public string Payment 
        {
            get { return payMethod.SelectedValue.ToString(); }
        }

        public bool Pet
        {
            get 
            { if (pet.Checked)
                    return true;                   
                return false; 
            }
        }

        public bool Bike
        {
            get
            {
                if (bike.Checked)
                    return true;
                return false;
            }
        }
           

        public bool Railrunner
        {
           get
            { if (railRunner.Checked) 
                    return true;                                  
                return false; 
            }
        }
    }
}
