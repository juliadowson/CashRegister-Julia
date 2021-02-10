using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    { 
        double burger = 6.00;
        double fries = 4.50;
        double drinks = 2.00;
        double burgerNumber;
        double friesNumber;
        double drinksNumber;
        double subTotal;
        double taxRate = 0.13;
        double tax;
        double totalCost;
        double tendered;
        double change;
        

    
        public Form1()
        {
            InitializeComponent();
            reciptLabel.Hide();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                burgerNumber = Convert.ToInt32(burgersInput.Text);
                friesNumber = Convert.ToInt32(friesInput.Text);
                drinksNumber = Convert.ToInt32(drinksInput.Text);
                subTotal = burger * burgerNumber + fries * friesNumber + drinks * drinksNumber;

                tax = taxRate * subTotal;
                totalCost = tax + subTotal;

                subtotalLabel.Text = $"{subTotal.ToString("C")} \n\n {tax.ToString("C")} \n\n {totalCost.ToString("C")}";
            }

            catch {
                reciptLabel.Show();
                reciptLabel.Text = "Please only input numbers"; 

              }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToInt32(tenderingInput.Text); 
            change = tendered - totalCost;
            changeLabel.Text = $"{change.ToString("C")}";
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            reciptLabel.Show();
            reciptLabel.Text = $"\n      Burger Time Inc. ";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\n\nBurgers:  x{ burgerNumber} @ { burger.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\nFries:    x{friesNumber} @ {fries.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\nDrinks:   x{drinksNumber} @ {drinks.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\n\nSubtotal:      {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\nTax:           {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\nTotal:         {totalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\n\nTendered:      {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\nChange:        {change.ToString("C")}"; 
            Refresh();
            Thread.Sleep(1000);
            reciptLabel.Text += $"\n\nHave a great day!";


        }

        private void newButton_Click(object sender, EventArgs e)
        {
            burgerNumber = 0;
            friesNumber = 0;
            drinksNumber = 0;
            tax = 0;
            subTotal = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;
            subtotalLabel.Text = "";
            changeLabel.Text = "";
            reciptLabel.Text = "";
            burgersInput.Text = "";
            friesInput.Text = "";
            drinksInput.Text = "";
            tenderingInput.Text = "";
        }
    }
}
