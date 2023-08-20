using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library_Management_System.PresentationLayer
{
    public partial class BookForm : Form
    {
        public int Id;
        public BookForm()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cat_comboBox.SelectedItem.ToString() == "Add New Category")
            {
                PresentationLayer.CategoryForm form = new PresentationLayer.CategoryForm();
                form.btn_add.ButtonText = "Add";
                form.Id = 0;
                form.Show();
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            try
            {
                Business_Layer.Category cat = new Business_Layer.Category();
                var dt = cat.Load();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var catName = dt.Rows[i]["CategoryName"].ToString();
                    Cat_comboBox.Items.Add(catName);
                }
                Cat_comboBox.Items.Add("Add New Category");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error in Loading data from Category");
            }
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (title_txt.Text.Length == 0 || authorName_txt.Text == "" || price_txt.Text == "")
            {
                MessageBox.Show("Please enter all the book details");
            }
            else
            {
                if (Id == 0)
                {
                    //Add
                    Business_Layer.Book book = new Business_Layer.Book();
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var title = title_txt.Text;
                    var authorName = authorName_txt.Text;
                    var category = Cat_comboBox.SelectedItem.ToString();
                    var price = price_txt.Text;
                    var rate = rating.Value;
                    var publishDate = bunifuDatePicker1.Value;
                    var bookCover = ms;
                    book.Insert(title, authorName, category, price, rate, publishDate, bookCover);
                    MessageBox.Show($"Book {title} added");
                    this.Close();
                }
                else
                {
                    Business_Layer.Book book = new Business_Layer.Book();
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var title = title_txt.Text;
                    var authorName = authorName_txt.Text;
                    var category = Cat_comboBox.Text;
                    var price = price_txt.Text;
                    var rate = rating.Value;
                    var publishDate = bunifuDatePicker1.Value;
                    var bookCover = ms;
                    book.Update(Id, title, authorName, category, price, rate, publishDate, bookCover);
                    MessageBox.Show($"Book {title} Edited");
                    this.Close();
                }
            }
        }
    }
}
