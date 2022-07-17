using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projext_of_SCD.DL;
using Projext_of_SCD.DTO;

namespace Projext_of_SCD.GUI
{
    public partial class HotelGUI : Form
    {
        string loction;
        public HotelGUI(string  z)
        {
            InitializeComponent();
            this.loction = z;
        }


        private void HotelGUI_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            HotelDTO hdto = new HotelDTO();
            hdto.location = this.loction;
            HotelData hdl = new HotelData();
            hdl.ShowHotelFromDB(hdto).Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void HotelGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
