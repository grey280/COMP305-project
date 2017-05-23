namespace SSL
{
    partial class EvaluateContractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluateContractor));
            System.Windows.Forms.Label contractorIDLabel;
            System.Windows.Forms.Label contractorNameLabel;
            System.Windows.Forms.Label contractorAddressLabel;
            System.Windows.Forms.Label contractorCityLabel;
            System.Windows.Forms.Label contractorStateLabel;
            System.Windows.Forms.Label contractorZipLabel;
            System.Windows.Forms.Label contractorPhoneLabel;
            System.Windows.Forms.Label contractorEmailLabel;
            System.Windows.Forms.Label contractorSkillsLabel;
            System.Windows.Forms.Label contractorOrganizationLabel;
            System.Windows.Forms.Label hiredByLabel;
            System.Windows.Forms.Label contractorCommentsLabel;
            this.sSLDataSet = new SSL.SSLDataSet();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorTableAdapter = new SSL.SSLDataSetTableAdapters.ContractorTableAdapter();
            this.tableAdapterManager = new SSL.SSLDataSetTableAdapters.TableAdapterManager();
            this.contractorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contractorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contractorIDTextBox = new System.Windows.Forms.TextBox();
            this.contractorNameTextBox = new System.Windows.Forms.TextBox();
            this.contractorAddressTextBox = new System.Windows.Forms.TextBox();
            this.contractorCityTextBox = new System.Windows.Forms.TextBox();
            this.contractorStateTextBox = new System.Windows.Forms.TextBox();
            this.contractorZipTextBox = new System.Windows.Forms.TextBox();
            this.contractorPhoneTextBox = new System.Windows.Forms.TextBox();
            this.contractorEmailTextBox = new System.Windows.Forms.TextBox();
            this.contractorSkillsTextBox = new System.Windows.Forms.TextBox();
            this.contractorOrganizationTextBox = new System.Windows.Forms.TextBox();
            this.hiredByTextBox = new System.Windows.Forms.TextBox();
            this.contractorCommentsTextBox = new System.Windows.Forms.TextBox();
            contractorIDLabel = new System.Windows.Forms.Label();
            contractorNameLabel = new System.Windows.Forms.Label();
            contractorAddressLabel = new System.Windows.Forms.Label();
            contractorCityLabel = new System.Windows.Forms.Label();
            contractorStateLabel = new System.Windows.Forms.Label();
            contractorZipLabel = new System.Windows.Forms.Label();
            contractorPhoneLabel = new System.Windows.Forms.Label();
            contractorEmailLabel = new System.Windows.Forms.Label();
            contractorSkillsLabel = new System.Windows.Forms.Label();
            contractorOrganizationLabel = new System.Windows.Forms.Label();
            hiredByLabel = new System.Windows.Forms.Label();
            contractorCommentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingNavigator)).BeginInit();
            this.contractorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSLDataSet
            // 
            this.sSLDataSet.DataSetName = "SSLDataSet";
            this.sSLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.sSLDataSet;
            // 
            // contractorTableAdapter
            // 
            this.contractorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationTableAdapter = null;
            this.tableAdapterManager.ContractorTableAdapter = this.contractorTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.HoursWorkedTableAdapter = null;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSL.SSLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contractorBindingNavigator
            // 
            this.contractorBindingNavigator.AddNewItem = null;
            this.contractorBindingNavigator.BindingSource = this.contractorBindingSource;
            this.contractorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractorBindingNavigator.DeleteItem = null;
            this.contractorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.contractorBindingNavigatorSaveItem});
            this.contractorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractorBindingNavigator.Name = "contractorBindingNavigator";
            this.contractorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractorBindingNavigator.Size = new System.Drawing.Size(342, 25);
            this.contractorBindingNavigator.TabIndex = 0;
            this.contractorBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contractorBindingNavigatorSaveItem
            // 
            this.contractorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractorBindingNavigatorSaveItem.Image")));
            this.contractorBindingNavigatorSaveItem.Name = "contractorBindingNavigatorSaveItem";
            this.contractorBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.contractorBindingNavigatorSaveItem.Text = "Save Data";
            this.contractorBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractorBindingNavigatorSaveItem_Click);
            // 
            // contractorIDLabel
            // 
            contractorIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorIDLabel.AutoSize = true;
            contractorIDLabel.Location = new System.Drawing.Point(58, 34);
            contractorIDLabel.Name = "contractorIDLabel";
            contractorIDLabel.Size = new System.Drawing.Size(73, 13);
            contractorIDLabel.TabIndex = 1;
            contractorIDLabel.Text = "Contractor ID:";
            // 
            // contractorIDTextBox
            // 
            this.contractorIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorID", true));
            this.contractorIDTextBox.Location = new System.Drawing.Point(185, 31);
            this.contractorIDTextBox.Name = "contractorIDTextBox";
            this.contractorIDTextBox.ReadOnly = true;
            this.contractorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorIDTextBox.TabIndex = 2;
            // 
            // contractorNameLabel
            // 
            contractorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorNameLabel.AutoSize = true;
            contractorNameLabel.Location = new System.Drawing.Point(58, 60);
            contractorNameLabel.Name = "contractorNameLabel";
            contractorNameLabel.Size = new System.Drawing.Size(90, 13);
            contractorNameLabel.TabIndex = 3;
            contractorNameLabel.Text = "Contractor Name:";
            // 
            // contractorNameTextBox
            // 
            this.contractorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorName", true));
            this.contractorNameTextBox.Location = new System.Drawing.Point(185, 57);
            this.contractorNameTextBox.Name = "contractorNameTextBox";
            this.contractorNameTextBox.ReadOnly = true;
            this.contractorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorNameTextBox.TabIndex = 4;
            // 
            // contractorAddressLabel
            // 
            contractorAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorAddressLabel.AutoSize = true;
            contractorAddressLabel.Location = new System.Drawing.Point(58, 86);
            contractorAddressLabel.Name = "contractorAddressLabel";
            contractorAddressLabel.Size = new System.Drawing.Size(100, 13);
            contractorAddressLabel.TabIndex = 5;
            contractorAddressLabel.Text = "Contractor Address:";
            // 
            // contractorAddressTextBox
            // 
            this.contractorAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorAddress", true));
            this.contractorAddressTextBox.Location = new System.Drawing.Point(185, 83);
            this.contractorAddressTextBox.Name = "contractorAddressTextBox";
            this.contractorAddressTextBox.ReadOnly = true;
            this.contractorAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorAddressTextBox.TabIndex = 6;
            // 
            // contractorCityLabel
            // 
            contractorCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorCityLabel.AutoSize = true;
            contractorCityLabel.Location = new System.Drawing.Point(58, 112);
            contractorCityLabel.Name = "contractorCityLabel";
            contractorCityLabel.Size = new System.Drawing.Size(79, 13);
            contractorCityLabel.TabIndex = 7;
            contractorCityLabel.Text = "Contractor City:";
            // 
            // contractorCityTextBox
            // 
            this.contractorCityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorCity", true));
            this.contractorCityTextBox.Location = new System.Drawing.Point(185, 109);
            this.contractorCityTextBox.Name = "contractorCityTextBox";
            this.contractorCityTextBox.ReadOnly = true;
            this.contractorCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorCityTextBox.TabIndex = 8;
            // 
            // contractorStateLabel
            // 
            contractorStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorStateLabel.AutoSize = true;
            contractorStateLabel.Location = new System.Drawing.Point(58, 138);
            contractorStateLabel.Name = "contractorStateLabel";
            contractorStateLabel.Size = new System.Drawing.Size(87, 13);
            contractorStateLabel.TabIndex = 9;
            contractorStateLabel.Text = "Contractor State:";
            // 
            // contractorStateTextBox
            // 
            this.contractorStateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorState", true));
            this.contractorStateTextBox.Location = new System.Drawing.Point(185, 135);
            this.contractorStateTextBox.Name = "contractorStateTextBox";
            this.contractorStateTextBox.ReadOnly = true;
            this.contractorStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorStateTextBox.TabIndex = 10;
            // 
            // contractorZipLabel
            // 
            contractorZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorZipLabel.AutoSize = true;
            contractorZipLabel.Location = new System.Drawing.Point(58, 164);
            contractorZipLabel.Name = "contractorZipLabel";
            contractorZipLabel.Size = new System.Drawing.Size(77, 13);
            contractorZipLabel.TabIndex = 11;
            contractorZipLabel.Text = "Contractor Zip:";
            // 
            // contractorZipTextBox
            // 
            this.contractorZipTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorZip", true));
            this.contractorZipTextBox.Location = new System.Drawing.Point(185, 161);
            this.contractorZipTextBox.Name = "contractorZipTextBox";
            this.contractorZipTextBox.ReadOnly = true;
            this.contractorZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorZipTextBox.TabIndex = 12;
            // 
            // contractorPhoneLabel
            // 
            contractorPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorPhoneLabel.AutoSize = true;
            contractorPhoneLabel.Location = new System.Drawing.Point(58, 190);
            contractorPhoneLabel.Name = "contractorPhoneLabel";
            contractorPhoneLabel.Size = new System.Drawing.Size(93, 13);
            contractorPhoneLabel.TabIndex = 13;
            contractorPhoneLabel.Text = "Contractor Phone:";
            // 
            // contractorPhoneTextBox
            // 
            this.contractorPhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorPhone", true));
            this.contractorPhoneTextBox.Location = new System.Drawing.Point(185, 187);
            this.contractorPhoneTextBox.Name = "contractorPhoneTextBox";
            this.contractorPhoneTextBox.ReadOnly = true;
            this.contractorPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorPhoneTextBox.TabIndex = 14;
            // 
            // contractorEmailLabel
            // 
            contractorEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorEmailLabel.AutoSize = true;
            contractorEmailLabel.Location = new System.Drawing.Point(58, 216);
            contractorEmailLabel.Name = "contractorEmailLabel";
            contractorEmailLabel.Size = new System.Drawing.Size(87, 13);
            contractorEmailLabel.TabIndex = 15;
            contractorEmailLabel.Text = "Contractor Email:";
            // 
            // contractorEmailTextBox
            // 
            this.contractorEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorEmail", true));
            this.contractorEmailTextBox.Location = new System.Drawing.Point(185, 213);
            this.contractorEmailTextBox.Name = "contractorEmailTextBox";
            this.contractorEmailTextBox.ReadOnly = true;
            this.contractorEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorEmailTextBox.TabIndex = 16;
            // 
            // contractorSkillsLabel
            // 
            contractorSkillsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorSkillsLabel.AutoSize = true;
            contractorSkillsLabel.Location = new System.Drawing.Point(58, 242);
            contractorSkillsLabel.Name = "contractorSkillsLabel";
            contractorSkillsLabel.Size = new System.Drawing.Size(86, 13);
            contractorSkillsLabel.TabIndex = 17;
            contractorSkillsLabel.Text = "Contractor Skills:";
            // 
            // contractorSkillsTextBox
            // 
            this.contractorSkillsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorSkillsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorSkills", true));
            this.contractorSkillsTextBox.Location = new System.Drawing.Point(185, 239);
            this.contractorSkillsTextBox.Name = "contractorSkillsTextBox";
            this.contractorSkillsTextBox.ReadOnly = true;
            this.contractorSkillsTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorSkillsTextBox.TabIndex = 18;
            // 
            // contractorOrganizationLabel
            // 
            contractorOrganizationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorOrganizationLabel.AutoSize = true;
            contractorOrganizationLabel.Location = new System.Drawing.Point(58, 268);
            contractorOrganizationLabel.Name = "contractorOrganizationLabel";
            contractorOrganizationLabel.Size = new System.Drawing.Size(121, 13);
            contractorOrganizationLabel.TabIndex = 19;
            contractorOrganizationLabel.Text = "Contractor Organization:";
            // 
            // contractorOrganizationTextBox
            // 
            this.contractorOrganizationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorOrganizationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorOrganization", true));
            this.contractorOrganizationTextBox.Location = new System.Drawing.Point(185, 265);
            this.contractorOrganizationTextBox.Name = "contractorOrganizationTextBox";
            this.contractorOrganizationTextBox.ReadOnly = true;
            this.contractorOrganizationTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorOrganizationTextBox.TabIndex = 20;
            // 
            // hiredByLabel
            // 
            hiredByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            hiredByLabel.AutoSize = true;
            hiredByLabel.Location = new System.Drawing.Point(58, 294);
            hiredByLabel.Name = "hiredByLabel";
            hiredByLabel.Size = new System.Drawing.Size(50, 13);
            hiredByLabel.TabIndex = 21;
            hiredByLabel.Text = "Hired By:";
            // 
            // hiredByTextBox
            // 
            this.hiredByTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hiredByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "HiredBy", true));
            this.hiredByTextBox.Location = new System.Drawing.Point(185, 291);
            this.hiredByTextBox.Name = "hiredByTextBox";
            this.hiredByTextBox.ReadOnly = true;
            this.hiredByTextBox.Size = new System.Drawing.Size(100, 20);
            this.hiredByTextBox.TabIndex = 22;
            // 
            // contractorCommentsLabel
            // 
            contractorCommentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contractorCommentsLabel.AutoSize = true;
            contractorCommentsLabel.Location = new System.Drawing.Point(58, 320);
            contractorCommentsLabel.Name = "contractorCommentsLabel";
            contractorCommentsLabel.Size = new System.Drawing.Size(111, 13);
            contractorCommentsLabel.TabIndex = 23;
            contractorCommentsLabel.Text = "Contractor Comments:";
            // 
            // contractorCommentsTextBox
            // 
            this.contractorCommentsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contractorCommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractorBindingSource, "ContractorComments", true));
            this.contractorCommentsTextBox.Location = new System.Drawing.Point(185, 317);
            this.contractorCommentsTextBox.Name = "contractorCommentsTextBox";
            this.contractorCommentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractorCommentsTextBox.TabIndex = 24;
            // 
            // EvaluateContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 346);
            this.Controls.Add(contractorIDLabel);
            this.Controls.Add(this.contractorIDTextBox);
            this.Controls.Add(contractorNameLabel);
            this.Controls.Add(this.contractorNameTextBox);
            this.Controls.Add(contractorAddressLabel);
            this.Controls.Add(this.contractorAddressTextBox);
            this.Controls.Add(contractorCityLabel);
            this.Controls.Add(this.contractorCityTextBox);
            this.Controls.Add(contractorStateLabel);
            this.Controls.Add(this.contractorStateTextBox);
            this.Controls.Add(contractorZipLabel);
            this.Controls.Add(this.contractorZipTextBox);
            this.Controls.Add(contractorPhoneLabel);
            this.Controls.Add(this.contractorPhoneTextBox);
            this.Controls.Add(contractorEmailLabel);
            this.Controls.Add(this.contractorEmailTextBox);
            this.Controls.Add(contractorSkillsLabel);
            this.Controls.Add(this.contractorSkillsTextBox);
            this.Controls.Add(contractorOrganizationLabel);
            this.Controls.Add(this.contractorOrganizationTextBox);
            this.Controls.Add(hiredByLabel);
            this.Controls.Add(this.hiredByTextBox);
            this.Controls.Add(contractorCommentsLabel);
            this.Controls.Add(this.contractorCommentsTextBox);
            this.Controls.Add(this.contractorBindingNavigator);
            this.Name = "EvaluateContractor";
            this.Text = "Evaluate Contractor";
            this.Load += new System.EventHandler(this.EvaluateContractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingNavigator)).EndInit();
            this.contractorBindingNavigator.ResumeLayout(false);
            this.contractorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SSLDataSet sSLDataSet;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private SSLDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter;
        private SSLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractorBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contractorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contractorIDTextBox;
        private System.Windows.Forms.TextBox contractorNameTextBox;
        private System.Windows.Forms.TextBox contractorAddressTextBox;
        private System.Windows.Forms.TextBox contractorCityTextBox;
        private System.Windows.Forms.TextBox contractorStateTextBox;
        private System.Windows.Forms.TextBox contractorZipTextBox;
        private System.Windows.Forms.TextBox contractorPhoneTextBox;
        private System.Windows.Forms.TextBox contractorEmailTextBox;
        private System.Windows.Forms.TextBox contractorSkillsTextBox;
        private System.Windows.Forms.TextBox contractorOrganizationTextBox;
        private System.Windows.Forms.TextBox hiredByTextBox;
        private System.Windows.Forms.TextBox contractorCommentsTextBox;
    }
}