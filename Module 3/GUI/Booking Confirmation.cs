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

            //định dạng output cho dpkBirhtdate 
            dpkBirthdate.Format = DateTimePickerFormat.Custom;
            dpkBirthdate.CustomFormat = "dd/MM/yyyy";

            InitTable();
            //LoadDataTable();
        }

        private void InitTable()
        {
            dgvPassgengersList.ColumnCount = 6;
            dgvPassgengersList.Columns[0].Name = "Firstname";
            dgvPassgengersList.Columns[1].Name = "Lastname";
            dgvPassgengersList.Columns[2].Name = "Birthdate";
            dgvPassgengersList.Columns[3].Name = "PassportNumber";
            dgvPassgengersList.Columns[4].Name = "PassportCountry";
            dgvPassgengersList.Columns[5].Name = "Phone";
            dgvPassgengersList.Columns[0].HeaderText = "Firstname";
            dgvPassgengersList.Columns[1].HeaderText = "Lastname";
            dgvPassgengersList.Columns[2].HeaderText = "Birthdate";
            dgvPassgengersList.Columns[3].HeaderText = "PassportNumber";
            dgvPassgengersList.Columns[4].HeaderText = "PassportCountry";
            dgvPassgengersList.Columns[5].HeaderText = "Phone";
            dgvPassgengersList.AutoResizeColumns();

        }

        /*lấy ra những thông tin của bản ghi có điều kiện là Tickets.ScheduleID = scheduleid(nhập vào) and
        CabinTypeID = cabintypeid(lấy từ shareddata)
        SELECT Tickets.ID, UserID, Fistname, Lastname, Birthdate, PassportNumber, PassportCountryID, Phone
        FROM Users inner join Tickets on Users.ID = Tickets.UserID
        WHERE Tickets.ScheduleID = scheduleid and CabinTypeID = cabintypeID*/
        /*private void LoadDataTable()
        {

        }*/

        private bool ValidationInput()
        {
            //validate empty
            if (String.IsNullOrWhiteSpace(txtFirstname.Text) || String.IsNullOrWhiteSpace(txtLastname.Text)  
                || String.IsNullOrWhiteSpace(txtPassportNumber.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || cbPassportCountry.SelectedIndex<0)
            {
                MessageBox.Show("The fields is not empty!", "Warning");
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
            Dictionary<string, string> one = new Dictionary<string, string>();
            one["Firstname"] = txtFirstname.Text;
            one["Lastname"] = txtLastname.Text;
            one["Birthday"] = dpkBirthdate.Value.ToString("dd/MM/yyyy");
            one["PassportNumber"] = txtPassportNumber.Text;
            one["PassportCountry"] = ((PassportCountryComboBox)(cbPassportCountry.SelectedItem)).Name_country;
            one["Phone"] = txtPhone.Text;
            dgvPassgengersList.Rows.Add(txtFirstname.Text, txtLastname.Text, dpkBirthdate.Value.ToString("dd/MM/yyyy"), txtPassportNumber.Text,
                ((PassportCountryComboBox)(cbPassportCountry.SelectedItem)).Name_country, txtPhone.Text);
        }
    }
}