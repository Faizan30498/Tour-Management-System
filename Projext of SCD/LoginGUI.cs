using Projext_of_SCD.BL;
using Projext_of_SCD.DTO;
using Projext_of_SCD.GUI;
using System.Text.RegularExpressions;
namespace Projext_of_SCD
{
    public partial class Login_main_page : Form
    {
        //Sign_up_page sig = new Sign_up_page()
       // sign_up_page sig = new sign_up_page();
       
        
        
       
       
        LoginDTO lDTO;
        loginBL lBL;
        public Login_main_page()
        {
            InitializeComponent();
            lDTO = new LoginDTO();
            lBL = new loginBL();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
           
            textBox2.PasswordChar = '\0';
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signGUI sig = new signGUI();
            sig.Owner = this;
            this.Hide();
            sig.ShowDialog();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

           // reg.IsMatch(textBox1.Text)
            if (textBox1.Text != string.Empty )
            {
                errorProvider1.SetError(textBox1, "");
                if (textBox2.Text != string.Empty && textBox2.Text.Length == 4 )
                {
                    errorProvider1.SetError(textBox2, "");
                    lDTO.useremail = textBox1.Text;
                    lDTO.pin = textBox2.Text;
                    int role = lBL.VerifyUser(lDTO);
                    if (role == 1)
                    {
                        AdminGUI g = new AdminGUI();
                        g.Owner = this;

                        this.Hide();
                        g.ShowDialog();

                    }
                    else if (role == 2)
                    {
                        UserGUI u = new UserGUI(textBox1.Text);
                        u.Owner = this;
                        this.Hide();
                        u.Show();

                    }
                    else
                    {
                        MessageBox.Show("User not register");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Invalid PIN ");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Invalid Email ");
            }
            
            


        }

        private void Login_main_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}