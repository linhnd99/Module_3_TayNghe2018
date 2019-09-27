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
        private class PassportCountryComboBox
        {
            private string id_country;
            private string name_country;

            public PassportCountryComboBox()
            {
            }
            public PassportCountryComboBox(string ID, string name)
            {
                id_country = ID;
                name_country = name;
            }
            public PassportCountryComboBox(Country x)
            {
                id_country = x.Id;
                name_country = x.Name;
            }
            public string Id_country { get => id_country; set => id_country = value; }
            public string Name_country { get => name_country; set => name_country = value; }

            public override string ToString()
            {
                return name_country;
            }
        }
        public frmBookingConfirmation()
        {
            InitializeComponent();
        }

        private void BtnBackToSearchForFlights_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmBooking_Click(object sender, EventArgs e)
        {
            frmBillingConfirmation frm2 = new frmBillingConfirmation();
            frm2.ShowDialog();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBirthday.Text))
            {
                //txtBirthday.ForeColor = Color.Gray;
                //txtBirthday.Text = "";
            }
        }
        public void AddText(object sender, EventArgs e)
        {
            //txtBirthday.ForeColor = Color.Black;
            //txtBirthday.Text = "[dd/mm/yyyy]";
        }

        private void FrmBookingConfirmation_Load(object sender, EventArgs e)
        {
            //GUI
            //txtBirthday.GotFocus += RemoveText;
            //txtBirthday.LostFocus += AddText;
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

            //Điền dữ liệu vào combobox Passport country
            CountryDAL countryDAL = new CountryDAL();
            List<Country> listCountries = countryDAL.GetAllCountries();
            foreach (Country x in listCountries)
            {
                cbPassportCountry.Items.Add(new PassportCountryComboBox(x));
            }
        }

        private bool ValidationInput()
        {
            //validate empty
            if (String.IsNullOrWhiteSpace(txtFirstname.Text) || String.IsNullOrWhiteSpace(txtLastname.Text) || String.IsNullOrWhiteSpace(txtBirthday.Text)  
                || String.IsNullOrWhiteSpace(txtPassportNumber.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || cbPassportCountry.SelectedIndex<0)
            {
                MessageBox.Show("The fields is not empty!", "Warning");
                return false;
            }
            //validate birthdate
            DateTime birthdate;
            try
            {
                birthdate = DateTime.Parse(txtBirthday.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Birthdate is invalid!", "Error");
                return false;
            }
            //validate phone number
            bool over = true;
            string x = txtPhone.Text;
            if ( ((x[0]<='9' && x[0]>='0') || x[0]=='+') == false)
            {
                over = false;
            }
            else 
                for (int i=1;i<x.Length;i++)
                    if (!(x[i]<='9' && x[i]>='0'))
                    {
                        over = false;
                        break;
                    }
            if (!over)
            {
                MessageBox.Show("Phone number is invalid!", "Error");
                return false;
            }
            return true;
        }
        private void BtnAddPassenger_Click(object sender, EventArgs e)
        {
            if (!ValidationInput())
                return;
        }
    }
}