using System;
using System.Windows.Forms;

namespace TicketMachine
{
    static class Paying
    {
        static public void finishPayment(float price, Ticket ticket)
        {
            if (ticket.Payment == "Contant") {
                MessageBox.Show("The ticket price is: " + price);
                MessageBox.Show("Please pay as close to the amount as possible");
                MessageBox.Show("Your change is: ");
            } else if (ticket.Payment == "Credit Card") {
                MessageBox.Show("Connecting to card reader");
                MessageBox.Show("The ticket price is" + price);
                MessageBox.Show("Follow the instructions on the card reader");
                MessageBox.Show("Transaction succesful");
            } else {
                MessageBox.Show("Connecting to card reader");
                MessageBox.Show("The ticket price is: " + price);
                MessageBox.Show("Follow the instructions on the card reader");
                MessageBox.Show("Transaction succesful");
            }
        }
    }
}