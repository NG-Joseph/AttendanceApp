using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AttendanceApp
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cmbrole.Text == "admin")
            {
                if(txtuser.Text =="Topsey" && txtpass.Text =="Topsey123")
                {
                    MessageBox.Show( "Welcome " + txtuser.Text , "Administrator");
                    Admin_Dashboard ad = new Admin_Dashboard();
                    ad.Show();
                    this.Hide();
                }
                else
                {

                }
            }
            else if(cmbrole.Text == "user")
            {
                if(txtuser.Text=="Creet" && txtpass.Text=="Creet123")
                {
                    MessageBox.Show( "Welcome  " + txtuser.Text, "User");
                }
            }
            else
            {

            }
          

        }

        private void Attendance_Load(object sender, EventArgs e)
        {/*
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Topsey Creet\Documents\Visual Studio 2019\Projects\AttendanceApp\Attendance_App.accdb;
            Persist Security Info= False;";
                connection.Open();
                label1.Text = "Test Completed";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }*/
        }
    }
}
