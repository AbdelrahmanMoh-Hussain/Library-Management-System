using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Library_Management_System.PresentationLayer
{
    public partial class StartUpForm : Form
    {
        private bool opendOnce = false;
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!opendOnce)
            {
                opendOnce = true;
                Business_Layer.User user = new Business_Layer.User();
                DataTable dt = user.GetUsersLogedIn();
                if (dt.Rows.Count > 0)
                {
                    Presentation_Layer.MainForm mainForm = new Presentation_Layer.MainForm();
                    mainForm.name_label.Text = dt.Rows[0]["Name"].ToString();
                    mainForm.perm_label.Text = dt.Rows[0]["Permission"].ToString();
                    mainForm.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
                else
                {
                    PresentationLayer.LoginForm loginForm = new PresentationLayer.LoginForm();
                    loginForm.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
