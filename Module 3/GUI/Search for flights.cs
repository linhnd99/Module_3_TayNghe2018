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
            AirportDAL airportDAL = new AirportDAL();
            List<Airport> listAirports = airportDAL.GetAllAirports();
            foreach (Airport x in listAirports)
            {
                cbFrom.Items.Add(new AirportComboBox(x));
                cbTo.Items.Add(new AirportComboBox(x));
            }
            CabinTypeDAL cabinTypeDAL = new CabinTypeDAL();
            List<CabinType> listCabinTypes = cabinTypeDAL.GetAllCabinTypes();
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
            bool isError = true;
            string strError = "";
            if (cbFrom.SelectedItem == null || cbTo.SelectedItem==null || cbCabinType.SelectedItem==null ||(!rdOneWay.Checked && !rdReturn.Checked))
            {
                isError = false;
                //MessageBox.Show("Fields can not empty!", "Warning");
                strError = strError + "Fields can not empty!\n";
            }
            if (rdReturn.Checked && dpkReturn.Value < dpkOutbound.Value)
            {
                isError = false;
                //MessageBox.Show("Returning date is not after outbound date!", "Warning");
                strError = strError + "Returning date is not after outbound date!\n";
            }
            if (isError == false)
            {
                MessageBox.Show(strError, "Warning!");
                return;
            }

            //Search Outbound
            // lấy hết những Route có DepartureID và ArrivalID trùng với cbFrom và cbTo, sau đó dùng RouteID tra Schedules
            // để lấy ra những Schedule có date phù hợp, trong đống Schedule đó dùng AircraftID tra bảng Aircrafts xem CabinType
            // có còn chỗ hay không? trả về cho bảng Outbound thông tin của những thằng thỏa mãn điều kiện trên
            // SELECT ArrivalID, DepartID, Date, Time, FlightNumber, CabinType FROM Routes,Schedule,Aircraft 
            // WHERE DepartID=departID and ArrivalID=arrivalID and is(DateFromAndTo)=OK
            // is(DateFromAndTo) = firstOutbound<=Date and Date <= lastOutbound
            // firstOutbound = dpkOutbound.Value.AddDays(-3);
            // lastOutbound = dpkOutbound.Value.AddDays(3);
            Dictionary<string, string> paramSearch = new Dictionary<string, string>();
            if (cbFrom.SelectedItem != null) paramSearch["DepartureAirportID"] = ((AirportComboBox)cbFrom.SelectedItem).Id;
            if (cbTo.SelectedItem != null) paramSearch["ArrivalAirportID"] = ((AirportComboBox)cbTo.SelectedItem).Id;
            DateTime firstDate = dpkOutbound.Value;
            DateTime lastDate = dpkOutbound.Value;
            if (chkThreeDaysOutbound.Checked)
            {
                firstDate = firstDate.AddDays(-3);
                lastDate = lastDate.AddDays(3);
            }
            paramSearch["FirstDate"] = firstDate.Date.ToString();
            paramSearch["LastDate"] = lastDate.Date.ToString();
            paramSearch["CabinType"] = ((CabinTypeComboBox)cbCabinType.SelectedItem).Name;
            List<Dictionary<string, string>> FlightsOutbound = new List<Dictionary<string, string>>();
            DBHelper dbHelper = new DBHelper();
            FlightsOutbound = dbHelper.GetFlightsWithParameters(param:paramSearch);
            if (FlightsOutbound == null) FlightsOutbound = new List<Dictionary<string, string>>();
            if (FlightsOutbound.Count==0) 
            {
                MessageBox.Show("No result!", "Notification");
                dgvOutboundFlight.Rows.Clear();
                return ;
            }
            foreach (Dictionary<string,string> row in FlightsOutbound)
            {
                dgvOutboundFlight.Rows.Add(row["DepartureAirportID"], row["ArrivalAirportID"], row["Date"], row["Time"], row["FlightNumber"], row["CabinType"], "0");
            }
        }

        private void CreateDataGridView()
        {
            dgvOutboundFlight.ColumnCount = 7;
            dgvOutboundFlight.Columns[0].Name = "From";
            dgvOutboundFlight.Columns[1].Name = "To";
            dgvOutboundFlight.Columns[2].Name = "Date";
            dgvOutboundFlight.Columns[3].Name = "Time";
            dgvOutboundFlight.Columns[4].Name = "FlightNumber";
            dgvOutboundFlight.Columns[5].Name = "CabinPrice";
            dgvOutboundFlight.Columns[6].Name = "NumberOfStops";
            dgvOutboundFlight.Columns[0].HeaderText = "From";
            dgvOutboundFlight.Columns[1].HeaderText = "To";
            dgvOutboundFlight.Columns[2].HeaderText = "Date";
            dgvOutboundFlight.Columns[3].HeaderText = "Time";
            dgvOutboundFlight.Columns[4].HeaderText = "Flight number(s)";
            dgvOutboundFlight.Columns[5].HeaderText = "Cabin Price";
            dgvOutboundFlight.Columns[6].HeaderText = "Number of stops";
            dgvOutboundFlight.AutoResizeColumns();

            dgvReturnFlight.ColumnCount = 7;
            dgvReturnFlight.Columns[0].Name = "From";
            dgvReturnFlight.Columns[1].Name = "To";
            dgvReturnFlight.Columns[2].Name = "Date";
            dgvReturnFlight.Columns[3].Name = "Time";
            dgvReturnFlight.Columns[4].Name = "Flight number(s)";
            dgvReturnFlight.Columns[5].Name = "Cabin Price";
            dgvReturnFlight.Columns[6].Name = "Number of stops";
            dgvReturnFlight.Columns[0].HeaderText = "From";
            dgvReturnFlight.Columns[1].HeaderText = "To";
            dgvReturnFlight.Columns[2].HeaderText = "Date";
            dgvReturnFlight.Columns[3].HeaderText = "Time";
            dgvReturnFlight.Columns[4].HeaderText = "Flight number(s)";
            dgvReturnFlight.Columns[5].HeaderText = "Cabin Price";
            dgvReturnFlight.Columns[6].HeaderText = "Number of stops";
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
