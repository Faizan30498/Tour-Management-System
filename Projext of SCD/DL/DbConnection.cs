using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projext_of_SCD.DL
{
    
    internal class DbConnection
    {
        
       
        private SqlConnection con;
       

        



        public DbConnection()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
          //  Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "C:\Users\power\Desktop\lab 14\Projext of SCD\Projext of SCD\"; Integrated Security = True
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"Database1.mdf;Integrated Security=True";
            // con = new SqlConnection(conString);
            con = new SqlConnection(conString);

        }

        public SqlConnection Con { get => con; }

        
    }
}
