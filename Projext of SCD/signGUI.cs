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
using System.Text.RegularExpressions;

namespace Projext_of_SCD
{
    public partial class signGUI : Form
    {
        sign_upBL sBL = new sign_upBL();
        public signGUI()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (textBox1.Text != string.Empty)
            {
                errorProvider1.SetError(textBox1, "");
                if (textBox2.Text != string.Empty && reg.IsMatch(textBox2.Text))
                {
                    errorProvider1.SetError(textBox2, "");
                    if (textBox3.Text != string.Empty && textBox3.Text.Length == 4)
                    {
                        errorProvider1.SetError(textBox3, "");
                        //
                        sign_upDTO Sdto = new sign_upDTO();
                        Sdto.name = textBox1.Text;
                        Sdto.email = textBox2.Text.ToLower();
                        Sdto.pin = Convert.ToInt32(textBox3.Text);
                        int x = sBL.Adddata(Sdto);
                        if (x == 1)
                        {
                            MessageBox.Show("Welcome", textBox1.Text);
                            this.Owner.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox3, "Invalid PIN ");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Invalid Email ");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "NULL NamE Not Allow ");
            }


        }

        private void signGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void signGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
