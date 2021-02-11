/*Julia Dowson
 Mr. T
 ICS3U
 February 11, 2021 
 A basic cash register code for a small Minecraft shop. A receipt can also be printed.*/
 

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
using System.Media;

namespace CashRegister
{
    public partial class Minecraft : Form
    { 
        //All the variables with costs were created. 
        double weapon = 9;
        double wood = 4;
        double mined = 6;
        double weaponNumber;
        double woodNumber;
        double minedNumber;
        double subTotal;
        double taxRate = 0.13;
        double tax;
        double totalCost;
        double tendered;
        double change;
        string orderName;
        

    
        public Minecraft()
        {
            InitializeComponent();
            receiptLabel.Hide();
        }

        //Prices of the items can be shown.
        private void pricesButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Show();
            receiptLabel.Text = $"\n    Minecraft Inventory " +
                $"\n\nWeapons:       {weapon.ToString("C")} each" +
                $"\nWood blocks:   {wood.ToString("C")} each" +
                $"\nMined blocks:  {mined.ToString("C")} each";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Hide();
            //If someone types something other than a number, an error is shown.
            try
            {

                weaponNumber = Convert.ToInt32(weaponsInput.Text);
                woodNumber = Convert.ToInt32(woodInput.Text);
                minedNumber = Convert.ToInt32(minedInput.Text);
                subTotal = weapon * weaponNumber + wood * woodNumber + mined * minedNumber;

                tax = taxRate * subTotal;
                totalCost = tax + subTotal;

                totalTaxLabel.Text = $"{subTotal.ToString("C")} \n\n {tax.ToString("C")} \n\n {totalCost.ToString("C")}";
            }

            catch 
            {
                receiptLabel.Show();
                receiptLabel.Text = "Please only input whole numbers"; 

            }
        }

        //The change is calculated below.
        private void changeButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Hide();
            try
            {
                tendered = Convert.ToDouble(tenderingInput.Text);
                change = tendered - totalCost;
                changeTotalLabel.Text = $"{change.ToString("C")}";
            }
            catch
            {
                receiptLabel.Show();
                receiptLabel.Text = "Please only input numbers";
            }
        }

        //The recipt is printed below. Each line is printed at a time.
        private void reciptButton_Click(object sender, EventArgs e)
        {
            orderName = ordernameInput.Text;
            
            SoundPlayer receipt = new SoundPlayer(Properties.Resources.receipt);
            receipt.Play();

            receiptLabel.Show();
            receiptLabel.Text = $"\n     Minecraft Inventory ";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nWeapon:         x{ weaponNumber} @ { weapon.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nWood Blocks:    x{woodNumber} @ {wood.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nMined Blocks:   x{minedNumber} @ {mined.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nSubtotal:            {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTax:                 {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTotal:               {totalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nTendered:            {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nChange:              {change.ToString("C")}"; 
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nHave a great day!";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nDate: {DateTime.Now.ToString()}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nOrder name: {orderName}";



        }

        //New order happens below. All the variables and textboxes are cleared.
        private void newButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Hide();           
            weaponNumber = 0;
            woodNumber = 0;
            minedNumber = 0;
            tax = 0;
            subTotal = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;
            totalTaxLabel.Text = "";
            changeTotalLabel.Text = "";
            receiptLabel.Text = "";
            weaponsInput.Text = "";
            woodInput.Text = "";
            minedInput.Text = "";
            tenderingInput.Text = "";
            ordernameInput.Text = "";
        }
    }
}
