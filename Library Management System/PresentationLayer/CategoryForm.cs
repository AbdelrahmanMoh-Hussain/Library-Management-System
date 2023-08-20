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
    public partial class CategoryForm : Form
    {
        public int Id;
        public string textBoxText;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name");
            }
            else
            {
                if(Id == 0)
                {
                    //Add
                    Business_Layer.Category category = new Business_Layer.Category();
                    category.Insert(textBox1.Text);
                    MessageBox.Show("Category added");
                    //textBoxText = textBox1.Text;
                    this.Close();
                }
                else
                {
                    Business_Layer.Category category = new Business_Layer.Category();
                    category.Update(textBox1.Text, Id);
                    MessageBox.Show("Category edited");
                    this.Close();
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
