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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void btn_add2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void btn_add3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }
    }
}
