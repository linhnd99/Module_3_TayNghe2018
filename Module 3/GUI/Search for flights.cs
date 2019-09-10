using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_3.DAL;
using Module_3.DTO;
using Module_3.GUI;

namespace Module_3
{
    public partial class frmSearchForLights : Form
    {
        private class AirportComboBox {
            string id;
            string iatacode;

            public AirportComboBox(Airport x)
            {
                this.id = x.Id;
                this.iatacode = x.IATACode;
            }

            public string Id { get => id; set => id = value; }
            public string Iatacode { get => iatacode; set => iatacode = value; }

            public override string ToString()
            {
                return Iatacode;
            }
        }
        private class CabinTypeComboBox
        {
            private string id;
            private string name;

            public CabinTypeComboBox(CabinType x)
            {
                this.id = x.Id;
                this.name = x.Name;
            }

            public string Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }

            public override string ToString()
            {
                return this.name;
            }
        }
        
        public frmSearchForLights()
        {
            InitializeComponent();
            if (rdReturn.Checked == true) dpkReturn.Enabled = true;
            else dpkReturn.Enabled = false;

            FillDataToComboBox();
            CreateDataGridView();
        }

        private void FillDataToComboBox()
        {
            List<Airport> listAirports = AirportDAL.GetAllAirports();
            foreach (Airport x in listAirports)
            {
                cbFrom.Items.Add(new AirportComboBox(x));
                cbTo.Items.Add(new AirportComboBox(x));
            }
            List<CabinType> listCabinTypes = CabinTypeDAL.GetAllCabinTypes();
            foreach (CabinType x in listCabinTypes)
            {
                cbCabinType.Items.Add(new CabinTypeComboBox(x));
            }
            cbCabinType.SelectedIndex = cbCabinType.FindString("Economy");
            dpkOutbound.Format = DateTimePickerFormat.Custom;
            dpkOutbound.CustomFormat = "dd/MM/yyyy";
            dpkReturn.Format = DateTimePickerFormat.Custom;
            dpkReturn.CustomFormat = "dd/MM/yyyy";
            dpkReturn.Value = DateTime.Now;
            dpkOutbound.Value = DateTime.Now;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Validate parameters
            if (cbFrom.SelectedItem == null || cbTo.SelectedItem==null || cbCabinType.SelectedItem==null)
            {
                MessageBox.Show("Fields can not empty!", "Warning");
            }
            if (rdReturn.Checked && dpkReturn.Value < dpkOutbound.Value)
            {
                MessageBox.Show("Returning date is not after outbound date!", "Warning");
            }

            //Search Outbound
            // lấy hết những Route có DepartureID và ArrivalID trùng với cbFrom và cbTo, sau đó dùng RouteID tra Schedules
            // để lấy ra những Schedule có date phù hợp, trong đống Schedule đó dùng AircraftID tra bảng Aircrafts xem CabinType
            // có còn chỗ hay không? trả về cho bảng Outbound thông tin của những thằng thỏa mãn điều kiện trên
            // SELECT ArrivalID, DepartID, Date, Time, FlightNumber, CabinType FROM Routes,Schedule,Aircraft 
            // WHERE DepartID=departID and ArrivalID=arrivalID and is(DateFromAndTo)=OK and is(SeatsOK)=OK
        }

        private void CreateDataGridView()
        {
            dgvOutboundFlight.ColumnCount = 7;
            dgvOutboundFlight.Columns[0].Name = "From";
            dgvOutboundFlight.Columns[1].Name = "To";
            dgvOutboundFlight.Columns[2].Name = "Date";
            dgvOutboundFlight.Columns[3].Name = "Time";
            dgvOutboundFlight.Columns[4].Name = "Flight number(s)";
            dgvOutboundFlight.Columns[5].Name = "Cabin Price";
            dgvOutboundFlight.Columns[6].Name = "Number of stops";
            dgvOutboundFlight.AutoResizeColumns();

            dgvReturnFlight.ColumnCount = 7;
            dgvReturnFlight.Columns[0].Name = "From";
            dgvReturnFlight.Columns[1].Name = "To";
            dgvReturnFlight.Columns[2].Name = "Date";
            dgvReturnFlight.Columns[3].Name = "Time";
            dgvReturnFlight.Columns[4].Name = "Flight number(s)";
            dgvReturnFlight.Columns[5].Name = "Cabin Price";
            dgvReturnFlight.Columns[6].Name = "Number of stops";
            dgvReturnFlight.AutoResizeColumns();
        }

        private void RdReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdReturn.Checked == true) dpkReturn.Enabled = true;
            else dpkReturn.Enabled= false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBookingFlight_Click(object sender, EventArgs e)
        {
            frmBookingConfirmation newFrm = new frmBookingConfirmation();
            newFrm.ShowDialog();
            //this.Visible = false;
            
        }
    }
}
