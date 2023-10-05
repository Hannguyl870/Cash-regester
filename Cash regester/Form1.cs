//hannah guylee
//october 2023
//cashregester program 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Cash_regester
{
    public partial class Form1 : Form
    {
        //global variables 
        double sliceprice = 1.50;
        int numberslices = 0;
        double slicetotal = 0;
        double wingprice = 0.67;
        int numberwings = 0;
        double wingstotal = 0;
        double drinkprice = 1.00;
        int numberdrink = 0;
        double drinktotal = 0;
        double subtotal = 0;
        double taxrate = 0.13;
        double taxamount = 0;
        double totalprice = 0;
        double change = 0;
        double tenderd = 0;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            numberslices = Convert.ToInt32(slicesinput.Text);
            numberdrink = Convert.ToInt32(drinkintput.Text);
            numberwings = Convert.ToInt32(wingsinput.Text);


            slicetotal = sliceprice * numberslices;
            drinktotal = drinkprice * numberdrink;
            wingstotal = wingprice * numberwings;

            subtotal = slicetotal + wingstotal + drinktotal;
            taxamount = taxrate * subtotal;
            totalprice = subtotal + taxamount;

           subtotaloutput.Text =$" {subtotal.ToString("C")}"; 
            Taxtoutput.Text = $" {taxamount.ToString("C")}";
            Totaloutput.Text = $" {totalprice.ToString("C")}";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tenderd = Convert.ToInt32(tenderedinput.Text);
            change = tenderd - totalprice;
            Changeoutput.Text = $"  {change.ToString("C")}";
        }

        private void Recieptoutput_Click(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            try
            {


                Recieptoutput.Text = $"           Welcome to foods are us\n\n";
                Refresh();
                Thread.Sleep(1000);
                Recieptoutput.Text += $"             order number 1031\n\n";
                Refresh();
                Thread.Sleep(1000);
                Recieptoutput.Text += $"{numberslices} pizza slices....   {slicetotal.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $"{numberwings}  wings....          {wingstotal.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $"{numberdrink}  drinks....         {drinktotal.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $" subtotal....         {subtotal.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $" Tax total....        {taxamount.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $" Total....            {totalprice.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $" Tenderd....          {tenderd.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $" change....           {change.ToString("C")}\n\n";
                Refresh();
                Thread.Sleep(500);
                Recieptoutput.Text += $"       Have a nice day (:";
            }
            catch
            {
                Recieptoutput.Text = "ERROR";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
    
}
