using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projext_of_SCD.BL;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;

namespace Projext_of_SCD.GUI
{
    public partial class Booked_trips : Form
    {
        string name;
        string email;
        string des;
        public Booked_trips(string n,string email, string des)
        {
            InitializeComponent();
            this.email = email;
            this.des = des;
            name = n;
        }

        private void Booked_trips_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            UpcommingTripsBL UTBL = new UpcommingTripsBL();
            UpcommingTripsDTO UTDTO = new UpcommingTripsDTO();
            UTDTO.email = this.email;
            UTDTO.desination = this.des;
            UTBL.GetUserUpcommingTrip(UTDTO).Fill(tbl);
            dataGridView1.DataSource = tbl;
            label1.Text = name + " your upcoming trips";
        }

        private void Booked_trips_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckTripMateBL cbl = new CheckTripMateBL(); 
            LoginDTO ldto = new LoginDTO();
            ldto.useremail = dataGridView1.CurrentCell.Value.ToString();
            button1.Text = Convert.ToString(cbl.CheckTripMate(ldto)-1) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
