using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_3.DTO;
using Module_3.DAL;

namespace Module_3.GUI
{
    public partial class frmBookingConfirmation : Form
    {
        public frmBookingConfirmation()
        {
            InitializeComponent();
        }

        private void BtnBackToSearchForFlights_Click(object sender, EventArgs e)
        {
            frmSearchForLights newFrm = new frmSearchForLights();
            newFrm.Show();
            this.Close();
        }

        private void BtnConfirmBooking_Click(object sender, EventArgs e)
        {
            frmBillingConfirmation frm2 = new frmBillingConfirmation();
            frm2.ShowDialog();
        }

        private void FrmBookingConfirmation_Load(object sender, EventArgs e)
        {
            //điền dữ liệu vào 2 group box Flight details
            lblFromOutboundValue.Text = SharedData.outboundFlight.From;
            lblToOutboundValue.Text = SharedData.outboundFlight.To;
            lblCabinTypeOutboundValue.Text = SharedData.outboundFlight.CabinType;
            lblDateOutboundValue.Text = SharedData.outboundFlight.Date.ToString("dd/MM/yyyy");
            lblFlightNumberOutboundValue.Text = SharedData.outboundFlight.FlightNumber;
            if (SharedData.returnFlight == null)
            {
                lblFromReturnValue.Text = "";
                lblToReturnValue.Text = "";
                lblCabinTypeReturnValue.Text = "";
                lblDateReturnValue.Text = "";
                lblFlightNumberReturnValue.Text = "";
            }
            else
            {
                lblFromReturnValue.Text = SharedData.returnFlight.From;
                lblToReturnValue.Text = SharedData.returnFlight.To;
                lblCabinTypeReturnValue.Text = SharedData.returnFlight.CabinType;
                lblDateReturnValue.Text = SharedData.returnFlight.Date.ToString("dd/MM/yyyy");
                lblFlightNumberReturnValue.Text = SharedData.returnFlight.FlightNumber;
            }
        }
    }
}