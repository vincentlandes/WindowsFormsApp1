using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    class Pricing
    {
        public float calculatePrice(string StartStation, string EndStation, string WayType, string Discount, string ClassType, string Payment, bool Pet, bool Bike, bool Railrunner) {
            float price = 0;
            price += calculateRoutePrice(StartStation, EndStation, WayType);
            price += calculateAddonPrice(Pet, Bike, Railrunner);
            price += calculateClassPrice(ClassType);
            price += calculatePaymentPrice(Payment);
            price = calculateDiscount(price, Discount);
            return price;
        }

        private float calculateRoutePrice(string StartStation, string EndStation, string WayType)
        {
            float routePrice = 0;
            //Bereken de route
            if (WayType == "Retour") {
                routePrice *= 2;
            }
            return routePrice;
        }

        private float calculateAddonPrice(bool Pet, bool Bike, bool Railrunner)
        {
            float addonPrice = 0;
            if (Pet) {
                addonPrice += 3.50f;
            }
            if (Bike) {
                addonPrice += 6.50f;
            }
            if (Railrunner) {
                addonPrice += 2.50f;
            }
            return addonPrice;
        }

        private float calculateClassPrice(string ClassType)
        {
            float classPrice = 0;
            if (ClassType == "FirstClass") {
                classPrice += 5.50f;
                return classPrice;
            } 
            return classPrice;
        }

        private float calculatePaymentPrice(string Payment) 
        {
            float paymentPrice = 0;
            if (Payment == "CreditCard") {
                paymentPrice += 0.50f;
            }
            return paymentPrice;
        }

        private float calculateDiscount(float price, string Discount)
        {            
            if (Discount == "DiscountFourty") {
                return price *= 0.6f;
            } else if (Discount == "DiscountTwenty") {
                return price *= 0.8f;
            } else {
                return price;
            }
        }
    }
}
