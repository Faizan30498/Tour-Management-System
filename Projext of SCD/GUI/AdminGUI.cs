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
using System.Data.SqlClient;


namespace Projext_of_SCD.GUI
{
    
    public partial class AdminGUI : Form
    {
        TripBL tBL = new TripBL();
        TripDTO tDto = new TripDTO();
        DataTable tbl = new DataTable();
        public AdminGUI()
        {
            InitializeComponent();
        }

        private void AdminGUI_Load(object sender, EventArgs e)
        {
           // DataTable tbl = new DataTable();
            ShowTrip s = new ShowTrip();
            s.ShowTripsFromDB().Fill(tbl);
            dataGridView1.DataSource = tbl;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text!= String.Empty )
            {
                errorProvider1.SetError(textBox1, "");
                if (textBox2.Text != String.Empty)
                {
                    errorProvider1.SetError(textBox2, "");
                    if (dataGridView1.CurrentCell.Value.ToString() != String.Empty)
                    {
                        errorProvider1.SetError(dataGridView1, "");
                        tDto.FROM = textBox1.Text;
                        tDto.TO = textBox2.Text;
                        int x = tBL.AddTripData(tDto);
                        if (x == 1)
                        {
                            MessageBox.Show("Trip added sucessfully");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(dataGridView1, "select value");
                    }


                }
                else
                {
                    errorProvider1.SetError(textBox2, "Null value");
                }


            }
           else
            {
                errorProvider1.SetError(textBox1, "Null value");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AdminGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Add hotel
            

            if (textBox3.Text != String.Empty)
            {
                errorProvider1.SetError(textBox3, "");
                if (textBox4.Text != String.Empty)
                {
                    errorProvider1.SetError(textBox4, "");
                    if (dataGridView1.CurrentCell.Value.ToString() != String.Empty)
                    {
                        //add here
                        HotelDTO hDTO = new HotelDTO();
                        hDTO.hotelName = textBox3.Text;
                        hDTO.Price = textBox4.Text;
                        hDTO.location = dataGridView1.CurrentCell.Value.ToString();

                        HotelBL hbl = new HotelBL();
                        int x = hbl.AddHoteldata(hDTO);
                        if (x == 1)
                        {
                            MessageBox.Show("Hotel added sucessfully");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(dataGridView1, "select value");
                    }


                }
                else
                {
                    errorProvider1.SetError(textBox4, "Null value");
                }


            }
            else
            {
                errorProvider1.SetError(textBox3, "Null value");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckActiveUserBL CBL = new CheckActiveUserBL();
            int y = CBL.CheckUser();
            label7.Text = Convert.ToString(y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteTripByAdminBL dbl = new DeleteTripByAdminBL();
            UserBookTripDTO bdto = new UserBookTripDTO();
            bdto.desination= dataGridView1.CurrentCell.Value.ToString();
            int x = dbl.DeleteTrip(bdto);
            if (x == 1)
            {
                MessageBox.Show("Trip deleted sucessfully");
            }
        }
    }
}
