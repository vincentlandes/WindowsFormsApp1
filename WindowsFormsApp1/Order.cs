using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    class Order
    {
        string StartStation;
        string EndStation; 
        string WayType; 
        string Discount; 
        string ClassType; 
        string Payment; 
        bool Pet; 
        bool Bike; 
        bool Railrunner;
        
        public Order(string StartStation, string EndStation, string WayType, string Discount, string ClassType, string Payment, bool Pet, bool Bike, bool Railrunner) 
        {
            this.StartStation = StartStation;
            this.EndStation = EndStation;
            this.WayType = WayType;
            this.Discount = Discount;
            this.ClassType = ClassType;
            this.Payment = Payment;
            this.Pet = Pet;
            this.Bike = Bike;
            this.Railrunner = Railrunner;

            makeTicket();
            float price = calculatePrice(StartStation, EndStation, WayType, Discount, ClassType, Payment, Pet, Bike, Railrunner);
            finishPayment(price, Payment);
        }
    }
}