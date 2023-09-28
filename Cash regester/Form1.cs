using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_regester
{
    public partial class Form1 : Form
    {
        //global variables 
        double pizzaprice = 1.50;
        int numberslices = 0;
        double wingprice = 0.67;
        int numberwings = 0;
        double drinkprice = 1.00;
        int numberdrink = 0;
        double subtotal = 0;
        double taxrate = 0.13;
        double totalprice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
