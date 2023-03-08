namespace sorOutByDate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.qry_Renewal_ListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qry_Renewal_ListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qry_Renewal_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uic_stickerDataSet = new sorOutByDate.uic_stickerDataSet();
            this.qry_Renewal_ListTableAdapter = new sorOutByDate.uic_stickerDataSetTableAdapters.qry_Renewal_ListTableAdapter();
            this.tableAdapterManager = new sorOutByDate.uic_stickerDataSetTableAdapters.TableAdapterManager();
            this.qry_SearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qry_SearchTableAdapter = new sorOutByDate.uic_stickerDataSetTableAdapters.qry_SearchTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.qry_Renewal_ListBindingNavigator)).BeginInit();
            this.qry_Renewal_ListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qry_Renewal_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uic_stickerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "pol_Dt_To", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(60, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(-4, 39);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(58, 20);
            this.From.TabIndex = 3;
            this.From.Text = "From";
            this.From.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(-4, 94);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(58, 20);
            this.To.TabIndex = 4;
            this.To.Text = "To";
            this.To.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.To.Click += new System.EventHandler(this.To_Click);
            // 
            // qry_Renewal_ListBindingNavigator
            // 
            this.qry_Renewal_ListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qry_Renewal_ListBindingNavigator.BindingSource = this.qry_Renewal_ListBindingSource;
            this.qry_Renewal_ListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qry_Renewal_ListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qry_Renewal_ListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qry_Renewal_ListBindingNavigatorSaveItem});
            this.qry_Renewal_ListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qry_Renewal_ListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qry_Renewal_ListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qry_Renewal_ListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qry_Renewal_ListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qry_Renewal_ListBindingNavigator.Name = "qry_Renewal_ListBindingNavigator";
            this.qry_Renewal_ListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qry_Renewal_ListBindingNavigator.Size = new System.Drawing.Size(871, 25);
            this.qry_Renewal_ListBindingNavigator.TabIndex = 5;
            this.qry_Renewal_ListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // qry_Renewal_ListBindingNavigatorSaveItem
            // 
            this.qry_Renewal_ListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qry_Renewal_ListBindingNavigatorSaveItem.Enabled = false;
            this.qry_Renewal_ListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qry_Renewal_ListBindingNavigatorSaveItem.Image")));
            this.qry_Renewal_ListBindingNavigatorSaveItem.Name = "qry_Renewal_ListBindingNavigatorSaveItem";
            this.qry_Renewal_ListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qry_Renewal_ListBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // qry_Renewal_ListBindingSource
            // 
            this.qry_Renewal_ListBindingSource.DataMember = "qry_Renewal_List";
            this.qry_Renewal_ListBindingSource.DataSource = this.uic_stickerDataSet;
            // 
            // uic_stickerDataSet
            // 
            this.uic_stickerDataSet.DataSetName = "uic_stickerDataSet";
            this.uic_stickerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qry_Renewal_ListTableAdapter
            // 
            this.qry_Renewal_ListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.Agency_ClassTableAdapter = null;
            this.tableAdapterManager.Agency_MasterTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Bank_DepositTableAdapter = null;
            this.tableAdapterManager.Branch_MasterTableAdapter = null;
            this.tableAdapterManager.Business_ClassTableAdapter = null;
            this.tableAdapterManager.Charge_MasterTableAdapter = null;
            this.tableAdapterManager.Claim_RegisterTableAdapter = null;
            this.tableAdapterManager.Commission_MasterTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Copy_Of_AccountsTableAdapter = null;
            this.tableAdapterManager.Cover_HistTableAdapter = null;
            this.tableAdapterManager.Cover_MasterTableAdapter = null;
            this.tableAdapterManager.CoverTableAdapter = null;
            this.tableAdapterManager.Currency_MasterTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Department_MasterTableAdapter = null;
            this.tableAdapterManager.Discount_LoadingTableAdapter = null;
            this.tableAdapterManager.Endorsement_MasterTableAdapter = null;
            this.tableAdapterManager.Mop_Up_DNTableAdapter = null;
            this.tableAdapterManager.Name_AutoCorrect_Save_FailuresTableAdapter = null;
            this.tableAdapterManager.Pol_Charges_HistTableAdapter = null;
            this.tableAdapterManager.Pol_ChargesTableAdapter = null;
            this.tableAdapterManager.Pol_Commission_HistTableAdapter = null;
            this.tableAdapterManager.Pol_CommissionTableAdapter = null;
            this.tableAdapterManager.Pol_Disc_Load_HistTableAdapter = null;
            this.tableAdapterManager.Pol_Disc_LoadTableAdapter = null;
            this.tableAdapterManager.Policy_HistTableAdapter = null;
            this.tableAdapterManager.PolicyTableAdapter = null;
            this.tableAdapterManager.Prem_reg_histTableAdapter = null;
            this.tableAdapterManager.PremiaTableAdapter = null;
            this.tableAdapterManager.premium_register_unpostedTableAdapter = null;
            this.tableAdapterManager.Premium_RegisterTableAdapter = null;
            this.tableAdapterManager.Prod_DateTableAdapter = null;
            this.tableAdapterManager.Property_UseTableAdapter = null;
            this.tableAdapterManager.Risk_HistTableAdapter = null;
            this.tableAdapterManager.Risk_MasterTableAdapter = null;
            this.tableAdapterManager.Risk_SMI_MasterTableAdapter = null;
            this.tableAdapterManager.RiskTableAdapter = null;
            this.tableAdapterManager.SMI_HistTableAdapter = null;
            this.tableAdapterManager.SMI_MasterTableAdapter = null;
            this.tableAdapterManager.SMITableAdapter = null;
            this.tableAdapterManager.Sub_ClassTableAdapter = null;
            this.tableAdapterManager.Tariff_11_Aug_2014TableAdapter = null;
            this.tableAdapterManager.TariffTableAdapter = null;
            this.tableAdapterManager.Travel_DetailTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sorOutByDate.uic_stickerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_MasterTableAdapter = null;
            this.tableAdapterManager.Veh_BodyTableAdapter = null;
            this.tableAdapterManager.Veh_CategoryTableAdapter = null;
            this.tableAdapterManager.Veh_Certificate_TypeTableAdapter = null;
            this.tableAdapterManager.Veh_MakeTableAdapter = null;
            this.tableAdapterManager.Vehicle_HistTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // qry_SearchBindingSource
            // 
            this.qry_SearchBindingSource.DataMember = "qry_Search";
            this.qry_SearchBindingSource.DataSource = this.uic_stickerDataSet;
            // 
            // qry_SearchTableAdapter
            // 
            this.qry_SearchTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "Cust_Name", true));
            this.textBox1.Location = new System.Drawing.Point(438, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "Veh_Regn_No", true));
            this.textBox2.Location = new System.Drawing.Point(438, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "Cust_Phone_No", true));
            this.textBox3.Location = new System.Drawing.Point(438, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "pol_Dt_To", true));
            this.textBox4.Location = new System.Drawing.Point(438, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qry_Renewal_ListBindingSource, "Premium", true));
            this.textBox5.Location = new System.Drawing.Point(438, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 20);
            this.textBox5.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(180, 185);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 34);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(60, 260);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(569, 100);
            this.DataGridView.TabIndex = 13;
            this.DataGridView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 382);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.qry_Renewal_ListBindingNavigator);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "UIC POLICY RENEWAL REMINDER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.Form1_QueryAccessibilityHelp);
            ((System.ComponentModel.ISupportInitialize)(this.qry_Renewal_ListBindingNavigator)).EndInit();
            this.qry_Renewal_ListBindingNavigator.ResumeLayout(false);
            this.qry_Renewal_ListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qry_Renewal_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uic_stickerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private uic_stickerDataSet uic_stickerDataSet;
        private System.Windows.Forms.BindingSource qry_Renewal_ListBindingSource;
        private uic_stickerDataSetTableAdapters.qry_Renewal_ListTableAdapter qry_Renewal_ListTableAdapter;
        private uic_stickerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qry_Renewal_ListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qry_Renewal_ListBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource qry_SearchBindingSource;
        private uic_stickerDataSetTableAdapters.qry_SearchTableAdapter qry_SearchTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel DataGridView;
    }
}

