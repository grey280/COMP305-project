namespace SSL
{
    partial class MaintainEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainEquipment));
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label equipmentTypeLabel;
            System.Windows.Forms.Label equipmentRentalCostLabel;
            System.Windows.Forms.Label equipmentBuyCostLabel;
            System.Windows.Forms.Label equipmentMaintenanceDateLabel;
            System.Windows.Forms.Label equipmentConditionLabel;
            System.Windows.Forms.Label equipmentCommentsLabel;
            System.Windows.Forms.Label rentedToLabel;
            this.sSLDataSet = new SSL.SSLDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new SSL.SSLDataSetTableAdapters.EquipmentTableAdapter();
            this.tableAdapterManager = new SSL.SSLDataSetTableAdapters.TableAdapterManager();
            this.equipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.equipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.equipmentRentalCostTextBox = new System.Windows.Forms.TextBox();
            this.equipmentBuyCostTextBox = new System.Windows.Forms.TextBox();
            this.equipmentMaintenanceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentConditionTextBox = new System.Windows.Forms.TextBox();
            this.equipmentCommentsTextBox = new System.Windows.Forms.TextBox();
            this.rentedToTextBox = new System.Windows.Forms.TextBox();
            equipmentIDLabel = new System.Windows.Forms.Label();
            equipmentTypeLabel = new System.Windows.Forms.Label();
            equipmentRentalCostLabel = new System.Windows.Forms.Label();
            equipmentBuyCostLabel = new System.Windows.Forms.Label();
            equipmentMaintenanceDateLabel = new System.Windows.Forms.Label();
            equipmentConditionLabel = new System.Windows.Forms.Label();
            equipmentCommentsLabel = new System.Windows.Forms.Label();
            rentedToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingNavigator)).BeginInit();
            this.equipmentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSLDataSet
            // 
            this.sSLDataSet.DataSetName = "SSLDataSet";
            this.sSLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.sSLDataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationTableAdapter = null;
            this.tableAdapterManager.ContractorTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager.HoursWorkedTableAdapter = null;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSL.SSLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equipmentBindingNavigator
            // 
            this.equipmentBindingNavigator.AddNewItem = null;
            this.equipmentBindingNavigator.BindingSource = this.equipmentBindingSource;
            this.equipmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipmentBindingNavigator.DeleteItem = null;
            this.equipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.equipmentBindingNavigatorSaveItem});
            this.equipmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipmentBindingNavigator.Name = "equipmentBindingNavigator";
            this.equipmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipmentBindingNavigator.Size = new System.Drawing.Size(446, 25);
            this.equipmentBindingNavigator.TabIndex = 0;
            this.equipmentBindingNavigator.Text = "bindingNavigator1";
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
            // equipmentBindingNavigatorSaveItem
            // 
            this.equipmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipmentBindingNavigatorSaveItem.Image")));
            this.equipmentBindingNavigatorSaveItem.Name = "equipmentBindingNavigatorSaveItem";
            this.equipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.equipmentBindingNavigatorSaveItem.Text = "Save Data";
            this.equipmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.equipmentBindingNavigatorSaveItem_Click);
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(45, 37);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(74, 13);
            equipmentIDLabel.TabIndex = 1;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox.Enabled = false;
            this.equipmentIDTextBox.Location = new System.Drawing.Point(202, 34);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentIDTextBox.TabIndex = 2;
            // 
            // equipmentTypeLabel
            // 
            equipmentTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentTypeLabel.AutoSize = true;
            equipmentTypeLabel.Location = new System.Drawing.Point(45, 63);
            equipmentTypeLabel.Name = "equipmentTypeLabel";
            equipmentTypeLabel.Size = new System.Drawing.Size(87, 13);
            equipmentTypeLabel.TabIndex = 3;
            equipmentTypeLabel.Text = "Equipment Type:";
            // 
            // equipmentTypeTextBox
            // 
            this.equipmentTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentType", true));
            this.equipmentTypeTextBox.Enabled = false;
            this.equipmentTypeTextBox.Location = new System.Drawing.Point(202, 60);
            this.equipmentTypeTextBox.Name = "equipmentTypeTextBox";
            this.equipmentTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentTypeTextBox.TabIndex = 4;
            // 
            // equipmentRentalCostLabel
            // 
            equipmentRentalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentRentalCostLabel.AutoSize = true;
            equipmentRentalCostLabel.Location = new System.Drawing.Point(45, 89);
            equipmentRentalCostLabel.Name = "equipmentRentalCostLabel";
            equipmentRentalCostLabel.Size = new System.Drawing.Size(118, 13);
            equipmentRentalCostLabel.TabIndex = 5;
            equipmentRentalCostLabel.Text = "Equipment Rental Cost:";
            // 
            // equipmentRentalCostTextBox
            // 
            this.equipmentRentalCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentRentalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentRentalCost", true));
            this.equipmentRentalCostTextBox.Enabled = false;
            this.equipmentRentalCostTextBox.Location = new System.Drawing.Point(202, 86);
            this.equipmentRentalCostTextBox.Name = "equipmentRentalCostTextBox";
            this.equipmentRentalCostTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentRentalCostTextBox.TabIndex = 6;
            // 
            // equipmentBuyCostLabel
            // 
            equipmentBuyCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentBuyCostLabel.AutoSize = true;
            equipmentBuyCostLabel.Location = new System.Drawing.Point(45, 115);
            equipmentBuyCostLabel.Name = "equipmentBuyCostLabel";
            equipmentBuyCostLabel.Size = new System.Drawing.Size(105, 13);
            equipmentBuyCostLabel.TabIndex = 7;
            equipmentBuyCostLabel.Text = "Equipment Buy Cost:";
            // 
            // equipmentBuyCostTextBox
            // 
            this.equipmentBuyCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentBuyCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentBuyCost", true));
            this.equipmentBuyCostTextBox.Enabled = false;
            this.equipmentBuyCostTextBox.Location = new System.Drawing.Point(202, 112);
            this.equipmentBuyCostTextBox.Name = "equipmentBuyCostTextBox";
            this.equipmentBuyCostTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentBuyCostTextBox.TabIndex = 8;
            // 
            // equipmentMaintenanceDateLabel
            // 
            equipmentMaintenanceDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentMaintenanceDateLabel.AutoSize = true;
            equipmentMaintenanceDateLabel.Location = new System.Drawing.Point(45, 142);
            equipmentMaintenanceDateLabel.Name = "equipmentMaintenanceDateLabel";
            equipmentMaintenanceDateLabel.Size = new System.Drawing.Size(151, 13);
            equipmentMaintenanceDateLabel.TabIndex = 9;
            equipmentMaintenanceDateLabel.Text = "Equipment Maintenance Date:";
            // 
            // equipmentMaintenanceDateDateTimePicker
            // 
            this.equipmentMaintenanceDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentMaintenanceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentBindingSource, "EquipmentMaintenanceDate", true));
            this.equipmentMaintenanceDateDateTimePicker.Location = new System.Drawing.Point(202, 138);
            this.equipmentMaintenanceDateDateTimePicker.Name = "equipmentMaintenanceDateDateTimePicker";
            this.equipmentMaintenanceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.equipmentMaintenanceDateDateTimePicker.TabIndex = 10;
            // 
            // equipmentConditionLabel
            // 
            equipmentConditionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentConditionLabel.AutoSize = true;
            equipmentConditionLabel.Location = new System.Drawing.Point(45, 167);
            equipmentConditionLabel.Name = "equipmentConditionLabel";
            equipmentConditionLabel.Size = new System.Drawing.Size(107, 13);
            equipmentConditionLabel.TabIndex = 11;
            equipmentConditionLabel.Text = "Equipment Condition:";
            // 
            // equipmentConditionTextBox
            // 
            this.equipmentConditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentConditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentCondition", true));
            this.equipmentConditionTextBox.Location = new System.Drawing.Point(202, 164);
            this.equipmentConditionTextBox.Name = "equipmentConditionTextBox";
            this.equipmentConditionTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentConditionTextBox.TabIndex = 12;
            // 
            // equipmentCommentsLabel
            // 
            equipmentCommentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            equipmentCommentsLabel.AutoSize = true;
            equipmentCommentsLabel.Location = new System.Drawing.Point(45, 193);
            equipmentCommentsLabel.Name = "equipmentCommentsLabel";
            equipmentCommentsLabel.Size = new System.Drawing.Size(112, 13);
            equipmentCommentsLabel.TabIndex = 13;
            equipmentCommentsLabel.Text = "Equipment Comments:";
            // 
            // equipmentCommentsTextBox
            // 
            this.equipmentCommentsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.equipmentCommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentComments", true));
            this.equipmentCommentsTextBox.Location = new System.Drawing.Point(202, 190);
            this.equipmentCommentsTextBox.Name = "equipmentCommentsTextBox";
            this.equipmentCommentsTextBox.Size = new System.Drawing.Size(200, 20);
            this.equipmentCommentsTextBox.TabIndex = 14;
            // 
            // rentedToLabel
            // 
            rentedToLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            rentedToLabel.AutoSize = true;
            rentedToLabel.Location = new System.Drawing.Point(45, 219);
            rentedToLabel.Name = "rentedToLabel";
            rentedToLabel.Size = new System.Drawing.Size(61, 13);
            rentedToLabel.TabIndex = 15;
            rentedToLabel.Text = "Rented To:";
            // 
            // rentedToTextBox
            // 
            this.rentedToTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rentedToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "RentedTo", true));
            this.rentedToTextBox.Location = new System.Drawing.Point(202, 216);
            this.rentedToTextBox.Name = "rentedToTextBox";
            this.rentedToTextBox.Size = new System.Drawing.Size(200, 20);
            this.rentedToTextBox.TabIndex = 16;
            // 
            // MaintainEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(equipmentIDLabel);
            this.Controls.Add(this.equipmentIDTextBox);
            this.Controls.Add(equipmentTypeLabel);
            this.Controls.Add(this.equipmentTypeTextBox);
            this.Controls.Add(equipmentRentalCostLabel);
            this.Controls.Add(this.equipmentRentalCostTextBox);
            this.Controls.Add(equipmentBuyCostLabel);
            this.Controls.Add(this.equipmentBuyCostTextBox);
            this.Controls.Add(equipmentMaintenanceDateLabel);
            this.Controls.Add(this.equipmentMaintenanceDateDateTimePicker);
            this.Controls.Add(equipmentConditionLabel);
            this.Controls.Add(this.equipmentConditionTextBox);
            this.Controls.Add(equipmentCommentsLabel);
            this.Controls.Add(this.equipmentCommentsTextBox);
            this.Controls.Add(rentedToLabel);
            this.Controls.Add(this.rentedToTextBox);
            this.Controls.Add(this.equipmentBindingNavigator);
            this.Name = "MaintainEquipment";
            this.Text = "Maintain Equipment";
            this.Load += new System.EventHandler(this.MaintainEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingNavigator)).EndInit();
            this.equipmentBindingNavigator.ResumeLayout(false);
            this.equipmentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SSLDataSet sSLDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private SSLDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private SSLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equipmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton equipmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        private System.Windows.Forms.TextBox equipmentTypeTextBox;
        private System.Windows.Forms.TextBox equipmentRentalCostTextBox;
        private System.Windows.Forms.TextBox equipmentBuyCostTextBox;
        private System.Windows.Forms.DateTimePicker equipmentMaintenanceDateDateTimePicker;
        private System.Windows.Forms.TextBox equipmentConditionTextBox;
        private System.Windows.Forms.TextBox equipmentCommentsTextBox;
        private System.Windows.Forms.TextBox rentedToTextBox;
    }
}