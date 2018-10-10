using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicketMachine.UI;

namespace TicketMachine
{
    public class Order
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
        }

        public Ticket makeTicket()
        {
            Ticket ticket = new Ticket(StartStation, EndStation, WayType, Discount, ClassType, Payment, Pet, Bike, Railrunner);
            return ticket;
        }

        public float calcPrice(Ticket ticket)
        {
            Pricing pricing = new Pricing();
            float price = pricing.calculatePrice(ticket);
            return price;
        }
    }
}