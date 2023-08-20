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
    public partial class TransactionForm: Form
    {
        public int Id;
        public string bookTitle;
        public TransactionForm()
        {
            InitializeComponent();
        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if(buyerName_txt.Text == "" || price_txt.Text == "")
            {
                MessageBox.Show("Please complete the details");
            }
            else
            {
                if(Id == 0)
                {
                    Business_Layer.Transaction transaction = new Business_Layer.Transaction();
                    var buyerName = buyerName_txt.Text;
                    var bookTitle = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    var price = Convert.ToInt32(price_txt.Text);
                    var date = bunifuDatePicker1.Value;
                    transaction.Insert(buyerName, bookTitle,price,date);
                    MessageBox.Show($"{bookTitle} sold succesfully to the buyer {buyerName}");
                    this.Close();
                }
                else
                {
                    Business_Layer.Transaction transaction = new Business_Layer.Transaction();
                    var buyerName = buyerName_txt.Text;
                    var price = Convert.ToInt32(price_txt.Text);
                    var date = bunifuDatePicker1.Value;
                    transaction.Update(Id,buyerName, bookTitle, price, date);
                    MessageBox.Show("Transaction Edited");
                    this.Close();
                }
                
            }
            
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            try
            {
                Business_Layer.Book book = new Business_Layer.Book();
                var allDetailsDT = book.Load();
                DataView dv = new DataView(allDetailsDT);
                DataTable dt = dv.ToTable("Books", false, "ISBN", "Title");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Business_Layer.Book book = new Business_Layer.Book();
            var bookIsbn = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var price = book.GetBookPrice(bookIsbn);
            price_txt.Text = Convert.ToString(price);
        }
    }
}
