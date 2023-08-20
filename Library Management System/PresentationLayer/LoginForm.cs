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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var userName = userName_txtbox.Text;
            var password = password_txtbox.Text;
            Business_Layer.User user = new Business_Layer.User();
            try
            {
                DataTable dt = user.Login(userName, password);
                if (dt.Rows.Count > 0)
                {
                    user.UpdateUserState(userName, password);
                    Presentation_Layer.MainForm mainForm = new Presentation_Layer.MainForm();
                    mainForm.name_label.Text = dt.Rows[0]["Name"].ToString();
                    mainForm.perm_label.Text = dt.Rows[0]["Permission"].ToString();
                    mainForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password");
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
