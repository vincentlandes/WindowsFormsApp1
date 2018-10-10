using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            Order order = new Order(StartStaiton,EndStation,WayType,Discount,ClassType,Payment,Pet,Bike,Railrunner);
            Ticket ticket = order.makeTicket();
            order.calcPrice(ticket);
        }

        public string StartStaiton
        {
            get {return startStation.SelectedValue.ToString();}
        }

        public string EndStation
        {
            get { return startStation.SelectedValue.ToString();}
        }

        public string WayType 
        {
            get { return wayType.SelectedValue.ToString();}
        }

        public string Discount
        {
            get { return discountType.SelectedValue.ToString();}
        }

        public string ClassType
        {
            get { return classType.SelectedValue.ToString();}
        }

        public string Payment 
        {
            get { return payMethod.SelectedValue.ToString();}
        }

        public bool Pet
        {
            get { 
                if (pet.Checked)
                    return true;                   
                return false; 
            }
        }

        public bool Bike
        {
            get {
                if (bike.Checked)
                    return true;
                return false;
            }
        }
           

        public bool Railrunner
        {
           get { 
                if (railRunner.Checked) 
                    return true;                                  
                return false; 
            }
        }
    }
}
