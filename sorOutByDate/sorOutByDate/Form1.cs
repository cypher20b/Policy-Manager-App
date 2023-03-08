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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uic_stickerDataSet.qry_Search' table. You can move, or remove it, as needed.
            this.qry_SearchTableAdapter.Fill(this.uic_stickerDataSet.qry_Search);
            // TODO: This line of code loads data into the 'uic_stickerDataSet.qry_Renewal_List' table. You can move, or remove it, as needed.
            this.qry_Renewal_ListTableAdapter.Fill(this.uic_stickerDataSet.qry_Renewal_List);
            qry_Renewal_ListBindingSource.DataSource = this.uic_stickerDataSet.qry_Renewal_List;

        }

        private void To_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (e.KeyChar == (char)13){
                if (string.IsNullOrEmpty(txtSearch.Text))
                    DataGridView.DataSource = qry_Renewal_ListBindingSource;
                else
                {

                    var query=from o in this.uic_stickerDataSet .qry_Renewal_List
                              where o.Cust_Name (txtSearch.Text) || o.Cust_Phone_No.Contains|| o.Veh_Regn_No==txtSearch.Text                               
                            select o;
                    DataGridView.DataSource = query.ToList();

                              }
    }
    }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
        
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        
        }
}