using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelmanegementsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Travel Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
           
            txtaddress.Clear();
            txtfristname.Clear();
            txtsurname.Clear();
            txtpostcode.Clear();
            txttelephone.Clear();
            txtemail.Clear();
            txtsubtotal.Clear();
            txttax.Clear();
            txttotal.Clear();

            txtdestination.Text = "None";
            txtdestination.Text = "None";
            txtaccommodation.Text = "None";


            chairporttax.Checked = true;
            chairmilesover.Checked = true;
            chtravelinsurance.Checked = true;
            chextluggage.Checked = true;

            rbeconomy.Checked = false;
            rbstandard.Checked = false;
            rbfristclass.Checked = false;

            chsingle.Checked = false;
            chreturn.Checked = false;
            chspecialneeds.Checked = false;
            chadult.Checked = false;
            chchild.Checked = false;
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            price travelprice = new price();
            itax airtax = new itax();

            double[] Travelcost = new double[20];
            double[] taxcost = new double[20];
            double total;
            if (txtdestination.Text == "Mumbai  - 1day")
            {
                Travelcost[0] = travelprice.Mumbai + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text=string.Format("{0:C}", total);
           }
            if (txtdestination.Text == "Dubai - 1day")
            {
                Travelcost[0] = travelprice.Dubai + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Male - 1day")
            {
                Travelcost[0] = travelprice.Male + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Kuala Lumpur - 1day")
            {
                Travelcost[0] = travelprice.Kuala_Lumpur + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Chengdu - 1day")
            {
                Travelcost[0] = travelprice.Chengdu + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Melbourne - 1day")
            {
                Travelcost[0] = travelprice.Melbourne + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Hong Knog - 1day")
            {
                Travelcost[0] = travelprice.HongKnog + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Chennai - 1day")
            {
                Travelcost[0] = travelprice.Chennai + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Singapore - 1day")
            {
                Travelcost[0] = travelprice.Singapore + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Bangalore - 1day")
            {
                Travelcost[0] = travelprice.Bangalore + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Guangzhou - 1day")
            {
                Travelcost[0] = travelprice.Guangzhou + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Doha - 1day")
            {
                Travelcost[0] = travelprice.Doha + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
            if (txtdestination.Text == "Hyderabad - 1day")
            {
                Travelcost[0] = travelprice.Hyderabad + travelprice.airporttax + travelprice.airmiles + travelprice.insurance + travelprice.extluggage;
                taxcost[0] = airtax.ifindtex(Travelcost[0]);
                total = Travelcost[0] + taxcost[0];

                txtsubtotal.Text = string.Format("{0:C}", Travelcost[0]);
                txttax.Text = string.Format("{0:C}", taxcost[0]);
                txttotal.Text = string.Format("{0:C}", total);
            }
          
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chairporttax.Checked = true;
            chairmilesover.Checked = true;
            chextluggage.Checked = true;
            chtravelinsurance.Checked = true;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

        }

       
    }
}
