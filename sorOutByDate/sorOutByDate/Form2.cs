using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorOutByDate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uic_stickerDataSet.qry_Search' table. You can move, or remove it, as needed.
            this.qry_SearchTableAdapter.Fill(this.uic_stickerDataSet.qry_Search);

        }
    }
}
