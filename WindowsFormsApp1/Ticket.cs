namespace WindowsFormsApp1
{
    class Ticket
    {
        public string StartStation;
        public string EndStation; 
        public string WayType; 
        public string Discount; 
        public string ClassType; 
        public string Payment; 
        public bool Pet; 
        public bool Bike; 
        public bool Railrunner;

        public Ticket(string StartStation, string EndStation, string WayType, string Discount, string ClassType, string Payment, bool Pet, bool Bike, bool Railrunner){
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
    }
}