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
    public partial class UserGUI : Form
    {
        private string name;
        private string email;
        public UserGUI(string email)
        {
            InitializeComponent();
            this.email = email;             
        }

        private void UserGUI_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            ShowTrip s = new ShowTrip();
            s.ShowTripsFromDB().Fill(tbl);
            dataGridView1.DataSource = tbl;

            // name and email
            nameDL nDL = new nameDL();
            NameDTO x;
            NameDTO DDTO=new NameDTO();
            DDTO.email = this.email;
            x = nDL.GetInfoFromDB(DDTO);
            this.name = x.name;
            label2.Text = x.name;
            label3.Text = x.email;

        }

        private void UserGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ///  textBox1.Text = dataGridView1.CurrentCell.Value.ToString()
            ///  ;
            UserBookTripDTO ubtdto = new UserBookTripDTO();
            UserBookTripBL ubtBL = new UserBookTripBL();
            
            
            ubtdto.email = this.email;
            ubtdto.desination = dataGridView1.CurrentCell.Value.ToString();

            int x = ubtBL.AddUserBookTrip(ubtdto);
            if(x==1)
            {
                MessageBox.Show("Trip Booked Sucesfully");
            }
            



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelGUI h = new HotelGUI(dataGridView1.CurrentCell.Value.ToString());
            h.Owner = this;
            this.Hide();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Booked_trips BT = new Booked_trips(this.name,this.email, dataGridView1.CurrentCell.Value.ToString());
            BT.Owner = this;
            this.Hide();
            BT.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
