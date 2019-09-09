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
        }
        private void btnApply_Click(object sender, EventArgs e)
        {

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
            newFrm.Show();
            //this.Visible = false;
            
        }
    }
}
