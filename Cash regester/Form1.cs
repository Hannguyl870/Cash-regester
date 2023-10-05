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
        double money = 0;
      

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

           subtotaloutput.Text =$"$ {subtotal}"; 
            Taxtoutput.Text = $"$ {taxamount}";
            Totaloutput.Text = $"$ {totalprice}";

        }

        private void Recieptoutput_Click(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            try
            {
                

                Recieptoutput.Text = $"           Welcome to foods are us\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $"{numberslices} pizza slices....  $ {slicetotal}\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $"{numberwings}  wings....         $ {wingstotal}\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $"{numberdrink}  drinks....        $ {drinktotal}\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $" subtotal....        $ {subtotal}\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $" Tax total....       $ {taxamount}\n\n";
                Thread.Sleep(500);
                Recieptoutput.Text += $" Total....           $ {totalprice}";
                Thread.Sleep(500);
            }
            catch
            {
                Recieptoutput.Text = "ERROR";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //change = money - totalprice;

            //Changeoutput.Text = $" $ {change}";
        }
    }
    
}
