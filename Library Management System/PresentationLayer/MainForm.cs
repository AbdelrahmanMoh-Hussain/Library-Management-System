using Library_Management_System.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Bunifu.Framework.UI;

namespace Library_Management_System.Presentation_Layer
{
    public partial class MainForm : Form
    {
        string State;

        //Var for classes
        Business_Layer.Category category = new Business_Layer.Category();
        Business_Layer.Book book = new Business_Layer.Book();
        Business_Layer.Transaction trans = new Business_Layer.Transaction();
        Business_Layer.User user = new Business_Layer.User();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Main Form Load & Activated
        //First screan Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            Home.Visible = true;
            Main.Visible = false;
            TitleLabel.Text = "Home";

        }

        //Main activity of the form, the update after any operation
        private void MainForm_Activated(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = book.Load();
                bookCount_label.Text = dt1.Rows.Count.ToString();
                DataTable dt2 = category.Load();
                catCount_label.Text = dt2.Rows.Count.ToString();
                DataTable dt3 = trans.Load();
                transCount_label.Text = dt3.Rows.Count.ToString();
                DataTable dt4 = user.Load();
                userCount_label.Text = dt4.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (perm_label.Text.ToUpper() == "USER")
            {
                bunifuThinButton23.Enabled = false;
                bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
                users_btn.Enabled = false;
            }
            else
            {
                bunifuThinButton23.Enabled = true;
                users_btn.Enabled = true;
            }

            if (State == "CAT")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = category.Load();
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "BOOK")
            {
                //Load data
                try
                {
                    DataTable dt = new DataTable();
                    dt = book.Load();
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "TRANS")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = trans.Load();
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "USER")
            {
                Home.Visible = false;
                Main.Visible = true;
                State = "USER";
                TitleLabel.Text = "USERS";
                bunifuThinButton24.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                //Load data
                try
                {
                    var allDetailsDT = user.Load();
                    DataView dv = new DataView(allDetailsDT);
                    DataTable dt = dv.ToTable("Users", false, "Id", "Name", "UserName", "Permission", "State");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Title Bar
        //Close btn
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Minmize btn
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Maxmize btn
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        #region Main Bar
        //Minimaze the MainBar btn (like hamburger button)
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if(MainBar.Size.Width == 256)
            {
                MainBar.Width = 60;
                home_btn.RightToLeft = RightToLeft.Yes;
                books_btn.RightToLeft = RightToLeft.Yes;
                trans_btn.RightToLeft = RightToLeft.Yes;
                users_btn.RightToLeft = RightToLeft.Yes;
                cat_btn.RightToLeft = RightToLeft.Yes;
                name_label.Visible = false;
                perm_label.Visible = false;
            }
            else
            {
                MainBar.Width = 256;
                home_btn.RightToLeft = RightToLeft.No;
                books_btn.RightToLeft = RightToLeft.No;
                trans_btn.RightToLeft = RightToLeft.No;
                users_btn.RightToLeft = RightToLeft.No;
                cat_btn.RightToLeft = RightToLeft.No;
                name_label.Visible = true;
                perm_label.Visible = true;
            }    
        }

        //Home btn
        private void button1_Click(object sender, EventArgs e)
        {
            Home.Visible = true;
            Main.Visible = false;
            State = "";
            TitleLabel.Text = "Home";
        }

        //Books btn
        private void button2_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Main.Visible = true;
            State = "BOOK";
            TitleLabel.Text = "Books";
            bunifuThinButton24.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = book.Load();
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Users btn
        private void button6_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Main.Visible = true;
            State = "USER";
            TitleLabel.Text = "USERS";
            bunifuThinButton24.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            //Load data
            try
            {
                var allDetailsDT = user.Load();
                DataView dv = new DataView(allDetailsDT);
                DataTable dt = dv.ToTable("Users", false, "Id", "Name", "UserName", "Permission", "State");
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Category btn
        private void button12_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Main.Visible = true;
            State = "CAT";
            TitleLabel.Text = "Categories";
            bunifuThinButton24.Visible = false;
            textBox1.Visible = true;
            label1.Visible = true;
            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = category.Load();
                dataGridView1.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Transaction btn
        private void button4_Click(object sender, EventArgs e)
        {
            Home.Visible = false;
            Main.Visible = true;
            State = "TRANS";
            TitleLabel.Text = "Transactions";
            bunifuThinButton24.Visible = false;
            textBox1.Visible = true;
            label1.Visible = true;

            //Load data
            try
            {
                DataTable dt = new DataTable();
                dt = trans.Load();
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Logout btn
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            PresentationLayer.LoginForm loginForm = new PresentationLayer.LoginForm();
            user.Logout();
            this.Hide();
            foreach (Form f in Application.OpenForms)
                f.Close();
            loginForm.Show();
        }

        //Report btn
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            PresentationLayer.ReportForm report = new PresentationLayer.ReportForm();
            report.label_name.Text = name_label.Text;
            report.label_perm.Text = perm_label.Text;
            report.label_date.Text = DateTime.Now.ToString("yyyy-MM-dd");

            report.bookCount_label.Text = bookCount_label.Text;
            report.catCount_label.Text = catCount_label.Text;
            report.transCount_label.Text = transCount_label.Text;
            report.userCount_label.Text = userCount_label.Text;
            report.Show();
        }

        #endregion

        #region Main Panel Buttons & Search bar
        //Add Button
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (State == "CAT")
            {
                PresentationLayer.CategoryForm form = new PresentationLayer.CategoryForm();
                form.btn_add.ButtonText = "Add";
                form.Id = 0;
                bunifuTransition1.ShowSync(form);
                form.Show();
            }
            else if (State == "BOOK")
            {
                PresentationLayer.BookForm form = new PresentationLayer.BookForm();
                form.btn_add.ButtonText = "Add";
                form.Id = 0;
                bunifuTransition1.ShowSync(form);
                form.Show();
            }
            else if(State == "TRANS")
            {
                PresentationLayer.TransactionForm form = new PresentationLayer.TransactionForm();
                form.btn_add.ButtonText = "Add";
                form.Id = 0;
                bunifuTransition1.ShowSync(form);
                form.Show();
            }
            else if (State == "USER")
            {
                PresentationLayer.UserForm form = new PresentationLayer.UserForm();
                form.btn_add.ButtonText = "Add";
                form.Id = 0;
                bunifuTransition1.ShowSync(form);
                form.Show();
            }
        }

        //Update Button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (State == "CAT")
            {
                PresentationLayer.CategoryForm form = new PresentationLayer.CategoryForm();
                form.btn_add.ButtonText = "Edit";
                form.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                form.Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(form);
                form.Show();
            }
            else if (State == "BOOK")
            {
                try
                {
                    PresentationLayer.BookForm form = new PresentationLayer.BookForm();
                    form.btn_add.ButtonText = "Edit";

                    DataTable dt = book.GetBookDetails(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

                    form.Id = Convert.ToInt32(dt.Rows[0]["ISBN"]);
                    form.title_txt.Text = Convert.ToString(dt.Rows[0]["Title"]);
                    form.authorName_txt.Text = Convert.ToString(dt.Rows[0]["Author"]);
                    form.Cat_comboBox.Text = Convert.ToString(dt.Rows[0]["Category"]);
                    form.price_txt.Text = Convert.ToString(dt.Rows[0]["Price"]);
                    form.rating.Value = Convert.ToInt32(dt.Rows[0]["Rate"]);
                    form.bunifuDatePicker1.Value = Convert.ToDateTime(dt.Rows[0]["PublishDate"]);
                    //Load img
                    byte[] bytes = (byte[])dt.Rows[0]["BookCover"];
                    MemoryStream ms = new MemoryStream(bytes);
                    form.pictureBox1.Image = Image.FromStream(ms);

                    bunifuTransition1.ShowSync(form);
                    form.Show();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else  if (State == "TRANS")
            {
                try
                {
                    PresentationLayer.TransactionForm form = new PresentationLayer.TransactionForm();
                    form.btn_add.ButtonText = "Edit";

                    form.Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    form.buyerName_txt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    form.bookTitle = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                    form.price_txt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                    form.bunifuDatePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                    

                    bunifuTransition1.ShowSync(form);
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "USER")
            {
                try
                {
                    PresentationLayer.UserForm form = new PresentationLayer.UserForm();
                    form.btn_add.ButtonText = "Edit";

                    form.Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    form.name_txtbox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    form.userName_txtbox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                    form.password_txtbox.Enabled = false;
                    form.comboBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

                    bunifuTransition1.ShowSync(form);
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Delete Button
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (State == "CAT")
            {
                var catID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                category.Delete(catID);
                MessageBox.Show("Category Deleted");
            }
            else if (State == "BOOK")
            {
                var bookIsbn = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var bookTitle = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                book.Delete(bookIsbn);
                MessageBox.Show($"Book {bookTitle} Deleted");
            }
            else if (State == "TRANS")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                trans.Delete(id);
                MessageBox.Show($"Transaction Deleted");
            }
            else if (State == "USER")
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                user.Delete(id);
                MessageBox.Show($"User Deleted");
            }
        }

        //Show info btn
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (State == "BOOK")
            {
                try
                {
                    PresentationLayer.BookForm form = new PresentationLayer.BookForm();
                    form.btn_add.Visible = false;

                    DataTable dt = book.GetBookDetails(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

                    form.Id = Convert.ToInt32(dt.Rows[0]["ISBN"]);
                    form.title_txt.Text = Convert.ToString(dt.Rows[0]["Title"]);
                    form.authorName_txt.Text = Convert.ToString(dt.Rows[0]["Author"]);
                    form.Cat_comboBox.Text = Convert.ToString(dt.Rows[0]["Category"]);
                    form.price_txt.Text = Convert.ToString(dt.Rows[0]["Price"]);
                    form.rating.Value = Convert.ToInt32(dt.Rows[0]["Rate"]);
                    form.bunifuDatePicker1.Value = Convert.ToDateTime(dt.Rows[0]["PublishDate"]);
                    //Load img
                    byte[] bytes = (byte[])dt.Rows[0]["BookCover"];
                    MemoryStream ms = new MemoryStream(bytes);
                    form.pictureBox1.Image = Image.FromStream(ms);

                    form.title_txt.ReadOnly = true;
                    form.authorName_txt.ReadOnly = true;
                    form.Cat_comboBox.Enabled = false;
                    form.price_txt.ReadOnly = true;
                    form.rating.ReadOnly = true;
                    form.bunifuDatePicker1.Enabled = false;
                    form.linkLabel1.Visible = false;

                    bunifuTransition1.ShowSync(form);
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Search bar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (State == "CAT")
            {
                var catName = textBox1.Text;
                try
                {
                    DataTable dt = new DataTable();
                    dt = category.Search(catName);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "BOOK")
            {
                var bookTitle = textBox1.Text;
                try
                {
                    DataTable dt = new DataTable();
                    dt = book.Search(bookTitle);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "TRANS")
            {
                var searchQuery = textBox1.Text;
                try
                {
                    DataTable dt = new DataTable();
                    dt = trans.Search(searchQuery);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Home Panel Buttons
        //Add book btn
        private void button7_Click(object sender, EventArgs e)
        {
            PresentationLayer.BookForm form = new PresentationLayer.BookForm();
            form.btn_add.ButtonText = "Add";
            form.Id = 0;
            bunifuTransition1.ShowSync(form);
            form.Show();
        }

        //Add Transaction btn
        private void button9_Click(object sender, EventArgs e)
        {
            PresentationLayer.TransactionForm form = new PresentationLayer.TransactionForm();
            form.btn_add.ButtonText = "Add";
            form.Id = 0;
            bunifuTransition1.ShowSync(form);
            form.Show();
        }

        //Add Category btn
        private void button10_Click(object sender, EventArgs e)
        {
            PresentationLayer.CategoryForm form = new PresentationLayer.CategoryForm();
            form.btn_add.ButtonText = "Add";
            form.Id = 0;
            bunifuTransition1.ShowSync(form);
            form.Show();
        }
        #endregion
    }
}
