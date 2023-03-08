namespace sorOutByDate
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.uic_stickerDataSet = new sorOutByDate.uic_stickerDataSet();
            this.qry_SearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qry_SearchTableAdapter = new sorOutByDate.uic_stickerDataSetTableAdapters.qry_SearchTableAdapter();
            this.tableAdapterManager = new sorOutByDate.uic_stickerDataSetTableAdapters.TableAdapterManager();
            this.qry_SearchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.qry_SearchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qry_SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uic_stickerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingNavigator)).BeginInit();
            this.qry_SearchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uic_stickerDataSet
            // 
            this.uic_stickerDataSet.DataSetName = "uic_stickerDataSet";
            this.uic_stickerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // qry_SearchBindingNavigator
            // 
            this.qry_SearchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qry_SearchBindingNavigator.BindingSource = this.qry_SearchBindingSource;
            this.qry_SearchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qry_SearchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qry_SearchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qry_SearchBindingNavigatorSaveItem});
            this.qry_SearchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qry_SearchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qry_SearchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qry_SearchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qry_SearchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qry_SearchBindingNavigator.Name = "qry_SearchBindingNavigator";
            this.qry_SearchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qry_SearchBindingNavigator.Size = new System.Drawing.Size(860, 25);
            this.qry_SearchBindingNavigator.TabIndex = 0;
            this.qry_SearchBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // qry_SearchBindingNavigatorSaveItem
            // 
            this.qry_SearchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qry_SearchBindingNavigatorSaveItem.Enabled = false;
            this.qry_SearchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qry_SearchBindingNavigatorSaveItem.Image")));
            this.qry_SearchBindingNavigatorSaveItem.Name = "qry_SearchBindingNavigatorSaveItem";
            this.qry_SearchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.qry_SearchBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // qry_SearchDataGridView
            // 
            this.qry_SearchDataGridView.AutoGenerateColumns = false;
            this.qry_SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qry_SearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.qry_SearchDataGridView.DataSource = this.qry_SearchBindingSource;
            this.qry_SearchDataGridView.Location = new System.Drawing.Point(0, 28);
            this.qry_SearchDataGridView.Name = "qry_SearchDataGridView";
            this.qry_SearchDataGridView.Size = new System.Drawing.Size(860, 443);
            this.qry_SearchDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pol_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pol_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cust_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cust_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Veh_Regn_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Veh_Regn_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cust_Code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cust_Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cust_Phone_No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cust_Phone_No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cust_Addr_1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cust_Addr_1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cust_Addr_2";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cust_Addr_2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cust_Addr_3";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cust_Addr_3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(860, 471);
            this.Controls.Add(this.qry_SearchDataGridView);
            this.Controls.Add(this.qry_SearchBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uic_stickerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchBindingNavigator)).EndInit();
            this.qry_SearchBindingNavigator.ResumeLayout(false);
            this.qry_SearchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qry_SearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uic_stickerDataSet uic_stickerDataSet;
        private System.Windows.Forms.BindingSource qry_SearchBindingSource;
        private uic_stickerDataSetTableAdapters.qry_SearchTableAdapter qry_SearchTableAdapter;
        private uic_stickerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qry_SearchBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qry_SearchBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qry_SearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}