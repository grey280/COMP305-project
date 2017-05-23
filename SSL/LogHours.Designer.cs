namespace SSL
{
    partial class LogHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogHours));
            System.Windows.Forms.Label timecardIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label timeInLabel;
            System.Windows.Forms.Label timeOutLabel;
            this.sSLDataSet = new SSL.SSLDataSet();
            this.hoursWorkedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursWorkedTableAdapter = new SSL.SSLDataSetTableAdapters.HoursWorkedTableAdapter();
            this.tableAdapterManager = new SSL.SSLDataSetTableAdapters.TableAdapterManager();
            this.hoursWorkedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hoursWorkedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timecardIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.timeInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            timecardIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            timeInLabel = new System.Windows.Forms.Label();
            timeOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedBindingNavigator)).BeginInit();
            this.hoursWorkedBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSLDataSet
            // 
            this.sSLDataSet.DataSetName = "SSLDataSet";
            this.sSLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoursWorkedBindingSource
            // 
            this.hoursWorkedBindingSource.DataMember = "HoursWorked";
            this.hoursWorkedBindingSource.DataSource = this.sSLDataSet;
            // 
            // hoursWorkedTableAdapter
            // 
            this.hoursWorkedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationTableAdapter = null;
            this.tableAdapterManager.ContractorTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.HoursWorkedTableAdapter = this.hoursWorkedTableAdapter;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSL.SSLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoursWorkedBindingNavigator
            // 
            this.hoursWorkedBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoursWorkedBindingNavigator.BindingSource = this.hoursWorkedBindingSource;
            this.hoursWorkedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoursWorkedBindingNavigator.DeleteItem = null;
            this.hoursWorkedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hoursWorkedBindingNavigatorSaveItem});
            this.hoursWorkedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoursWorkedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoursWorkedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoursWorkedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoursWorkedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoursWorkedBindingNavigator.Name = "hoursWorkedBindingNavigator";
            this.hoursWorkedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoursWorkedBindingNavigator.Size = new System.Drawing.Size(378, 25);
            this.hoursWorkedBindingNavigator.TabIndex = 0;
            this.hoursWorkedBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // hoursWorkedBindingNavigatorSaveItem
            // 
            this.hoursWorkedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoursWorkedBindingNavigatorSaveItem.Image")));
            this.hoursWorkedBindingNavigatorSaveItem.Name = "hoursWorkedBindingNavigatorSaveItem";
            this.hoursWorkedBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.hoursWorkedBindingNavigatorSaveItem.Text = "Save Data";
            this.hoursWorkedBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoursWorkedBindingNavigatorSaveItem_Click);
            // 
            // timecardIDLabel
            // 
            timecardIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            timecardIDLabel.AutoSize = true;
            timecardIDLabel.Location = new System.Drawing.Point(50, 42);
            timecardIDLabel.Name = "timecardIDLabel";
            timecardIDLabel.Size = new System.Drawing.Size(68, 13);
            timecardIDLabel.TabIndex = 1;
            timecardIDLabel.Text = "Timecard ID:";
            // 
            // timecardIDTextBox
            // 
            this.timecardIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timecardIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoursWorkedBindingSource, "TimecardID", true));
            this.timecardIDTextBox.Location = new System.Drawing.Point(126, 39);
            this.timecardIDTextBox.Name = "timecardIDTextBox";
            this.timecardIDTextBox.ReadOnly = true;
            this.timecardIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.timecardIDTextBox.TabIndex = 2;
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(50, 68);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 3;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoursWorkedBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(126, 65);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // timeInLabel
            // 
            timeInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            timeInLabel.AutoSize = true;
            timeInLabel.Location = new System.Drawing.Point(50, 95);
            timeInLabel.Name = "timeInLabel";
            timeInLabel.Size = new System.Drawing.Size(45, 13);
            timeInLabel.TabIndex = 5;
            timeInLabel.Text = "Time In:";
            // 
            // timeInDateTimePicker
            // 
            this.timeInDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeInDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoursWorkedBindingSource, "TimeIn", true));
            this.timeInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInDateTimePicker.Location = new System.Drawing.Point(126, 91);
            this.timeInDateTimePicker.Name = "timeInDateTimePicker";
            this.timeInDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeInDateTimePicker.TabIndex = 6;
            // 
            // timeOutLabel
            // 
            timeOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            timeOutLabel.AutoSize = true;
            timeOutLabel.Location = new System.Drawing.Point(50, 121);
            timeOutLabel.Name = "timeOutLabel";
            timeOutLabel.Size = new System.Drawing.Size(53, 13);
            timeOutLabel.TabIndex = 7;
            timeOutLabel.Text = "Time Out:";
            // 
            // timeOutDateTimePicker
            // 
            this.timeOutDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeOutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoursWorkedBindingSource, "TimeOut", true));
            this.timeOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOutDateTimePicker.Location = new System.Drawing.Point(126, 117);
            this.timeOutDateTimePicker.Name = "timeOutDateTimePicker";
            this.timeOutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeOutDateTimePicker.TabIndex = 8;
            // 
            // LogHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 148);
            this.Controls.Add(timecardIDLabel);
            this.Controls.Add(this.timecardIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(timeInLabel);
            this.Controls.Add(this.timeInDateTimePicker);
            this.Controls.Add(timeOutLabel);
            this.Controls.Add(this.timeOutDateTimePicker);
            this.Controls.Add(this.hoursWorkedBindingNavigator);
            this.Name = "LogHours";
            this.Text = "LogHours";
            this.Load += new System.EventHandler(this.LogHours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sSLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedBindingNavigator)).EndInit();
            this.hoursWorkedBindingNavigator.ResumeLayout(false);
            this.hoursWorkedBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SSLDataSet sSLDataSet;
        private System.Windows.Forms.BindingSource hoursWorkedBindingSource;
        private SSLDataSetTableAdapters.HoursWorkedTableAdapter hoursWorkedTableAdapter;
        private SSLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoursWorkedBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hoursWorkedBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox timecardIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker timeInDateTimePicker;
        private System.Windows.Forms.DateTimePicker timeOutDateTimePicker;
    }
}