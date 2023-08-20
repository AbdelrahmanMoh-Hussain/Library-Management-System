using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.PresentationLayer
{
    public partial class UserForm : Form
    {
        public int Id;
        public UserForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(name_txt.Text == "" || username_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Please enter all the user details");
            }
            else
            {
                if(Id == 0)
                {
                    Business_Layer.User user = new Business_Layer.User();
                    var name = name_txtbox.Text;
                    var username = userName_txtbox.Text;
                    var password = password_txtbox.Text;
                    var permission = comboBox1.Text;
                    user.Insert(name, username, password, permission, "FALSE");
                    MessageBox.Show($"User {name} added");
                    this.Close();
                }
                else
                {
                    Business_Layer.User user = new Business_Layer.User();
                    var name = name_txtbox.Text;
                    var username = userName_txtbox.Text;
                    var password = password_txtbox.Text;
                    var permission = comboBox1.Text;
                    user.Update(Id, name, username, password, permission);
                    MessageBox.Show($"User {name} Edited");
                    this.Close();
                }
            }
        }
    }
}
