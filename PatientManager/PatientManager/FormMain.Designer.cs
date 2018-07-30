namespace PatientManager
{
    partial class FormMain
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
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliveredGrid = new System.Windows.Forms.DataGridView();
            this.DischargeButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnticipatedGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NurseryListBox = new System.Windows.Forms.ListBox();
            this.PPListBox = new System.Windows.Forms.ListBox();
            this.UAPListBox = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StaffOnShiftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinNursesLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DischargesLabel = new System.Windows.Forms.Label();
            this.NsyCensusLabel = new System.Windows.Forms.Label();
            this.PPCensusLabel = new System.Windows.Forms.Label();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICUDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anticipatedPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveredPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HomeToday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICUDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acuityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIHDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveredGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(1366, 1117);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(236, 102);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 1077);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anticipated Patients";
            // 
            // DeliveredGrid
            // 
            this.DeliveredGrid.AllowUserToAddRows = false;
            this.DeliveredGrid.AllowUserToDeleteRows = false;
            this.DeliveredGrid.AutoGenerateColumns = false;
            this.DeliveredGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveredGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HomeToday,
            this.roomDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.patientTypeDataGridViewTextBoxColumn,
            this.nICUDataGridViewCheckBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10,
            this.attendingDataGridViewTextBoxColumn,
            this.acuityDataGridViewTextBoxColumn,
            this.pIHDataGridViewCheckBoxColumn});
            this.DeliveredGrid.DataSource = this.deliveredPatientBindingSource;
            this.DeliveredGrid.Location = new System.Drawing.Point(64, 94);
            this.DeliveredGrid.Margin = new System.Windows.Forms.Padding(6);
            this.DeliveredGrid.Name = "DeliveredGrid";
            this.DeliveredGrid.Size = new System.Drawing.Size(1836, 942);
            this.DeliveredGrid.TabIndex = 7;
            // 
            // DischargeButton
            // 
            this.DischargeButton.Location = new System.Drawing.Point(1662, 1117);
            this.DischargeButton.Margin = new System.Windows.Forms.Padding(6);
            this.DischargeButton.Name = "DischargeButton";
            this.DischargeButton.Size = new System.Drawing.Size(238, 106);
            this.DischargeButton.TabIndex = 8;
            this.DischargeButton.Text = "Discharge Patient";
            this.DischargeButton.UseVisualStyleBackColor = true;
            this.DischargeButton.Click += new System.EventHandler(this.DischargeButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn1.HeaderText = "Room";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientType";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatientType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn4.HeaderText = "Room";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatientType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // AnticipatedGrid
            // 
            this.AnticipatedGrid.AutoGenerateColumns = false;
            this.AnticipatedGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AnticipatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnticipatedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn1,
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn1,
            this.attendingDataGridViewTextBoxColumn1,
            this.nICUDataGridViewCheckBoxColumn1});
            this.AnticipatedGrid.DataSource = this.anticipatedPatientBindingSource;
            this.AnticipatedGrid.Location = new System.Drawing.Point(64, 1121);
            this.AnticipatedGrid.Margin = new System.Windows.Forms.Padding(6);
            this.AnticipatedGrid.Name = "AnticipatedGrid";
            this.AnticipatedGrid.ReadOnly = true;
            this.AnticipatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnticipatedGrid.Size = new System.Drawing.Size(1094, 288);
            this.AnticipatedGrid.TabIndex = 9;
            this.AnticipatedGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnticipatedGrid_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Family Suites";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(1010, 17);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(84, 37);
            this.DayLabel.TabIndex = 11;
            this.DayLabel.Text = "Date";
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftLabel.Location = new System.Drawing.Point(1250, 17);
            this.ShiftLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(81, 37);
            this.ShiftLabel.TabIndex = 12;
            this.ShiftLabel.Text = "Shift";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1452, 17);
            this.NextButton.Margin = new System.Windows.Forms.Padding(6);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(150, 44);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next Shift";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1998, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nursery Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1998, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Postpartum Staff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1998, 860);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unlicensed Staff";
            // 
            // NurseryListBox
            // 
            this.NurseryListBox.FormattingEnabled = true;
            this.NurseryListBox.ItemHeight = 25;
            this.NurseryListBox.Location = new System.Drawing.Point(2004, 242);
            this.NurseryListBox.Margin = new System.Windows.Forms.Padding(6);
            this.NurseryListBox.Name = "NurseryListBox";
            this.NurseryListBox.Size = new System.Drawing.Size(314, 154);
            this.NurseryListBox.TabIndex = 21;
            // 
            // PPListBox
            // 
            this.PPListBox.FormattingEnabled = true;
            this.PPListBox.ItemHeight = 25;
            this.PPListBox.Location = new System.Drawing.Point(2004, 458);
            this.PPListBox.Margin = new System.Windows.Forms.Padding(6);
            this.PPListBox.Name = "PPListBox";
            this.PPListBox.Size = new System.Drawing.Size(314, 354);
            this.PPListBox.TabIndex = 22;
            // 
            // UAPListBox
            // 
            this.UAPListBox.FormattingEnabled = true;
            this.UAPListBox.ItemHeight = 25;
            this.UAPListBox.Location = new System.Drawing.Point(2004, 890);
            this.UAPListBox.Margin = new System.Windows.Forms.Padding(6);
            this.UAPListBox.Name = "UAPListBox";
            this.UAPListBox.Size = new System.Drawing.Size(314, 79);
            this.UAPListBox.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PatientType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn7.HeaderText = "Room";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PatientType";
            this.dataGridViewTextBoxColumn8.HeaderText = "Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AnticipatedDeliveryType";
            this.dataGridViewTextBoxColumn9.HeaderText = "AnticipatedDeliveryType";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "PP Census";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nsy Census";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Discharges";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1366, 1254);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 102);
            this.button1.TabIndex = 27;
            this.button1.Text = "Block Room";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StaffOnShiftButton
            // 
            this.StaffOnShiftButton.Location = new System.Drawing.Point(1664, 1254);
            this.StaffOnShiftButton.Margin = new System.Windows.Forms.Padding(6);
            this.StaffOnShiftButton.Name = "StaffOnShiftButton";
            this.StaffOnShiftButton.Size = new System.Drawing.Size(236, 102);
            this.StaffOnShiftButton.TabIndex = 28;
            this.StaffOnShiftButton.Text = "Staff Assignments";
            this.StaffOnShiftButton.UseVisualStyleBackColor = true;
            this.StaffOnShiftButton.Click += new System.EventHandler(this.StaffOnShiftButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinNursesLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DischargesLabel);
            this.groupBox1.Controls.Add(this.NsyCensusLabel);
            this.groupBox1.Controls.Add(this.PPCensusLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(2004, 1117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(442, 292);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // MinNursesLabel
            // 
            this.MinNursesLabel.AutoSize = true;
            this.MinNursesLabel.Location = new System.Drawing.Point(248, 106);
            this.MinNursesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MinNursesLabel.Name = "MinNursesLabel";
            this.MinNursesLabel.Size = new System.Drawing.Size(24, 25);
            this.MinNursesLabel.TabIndex = 31;
            this.MinNursesLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Minimum Nurses";
            // 
            // DischargesLabel
            // 
            this.DischargesLabel.AutoSize = true;
            this.DischargesLabel.Location = new System.Drawing.Point(248, 237);
            this.DischargesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DischargesLabel.Name = "DischargesLabel";
            this.DischargesLabel.Size = new System.Drawing.Size(24, 25);
            this.DischargesLabel.TabIndex = 29;
            this.DischargesLabel.Text = "0";
            // 
            // NsyCensusLabel
            // 
            this.NsyCensusLabel.AutoSize = true;
            this.NsyCensusLabel.Location = new System.Drawing.Point(248, 173);
            this.NsyCensusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NsyCensusLabel.Name = "NsyCensusLabel";
            this.NsyCensusLabel.Size = new System.Drawing.Size(24, 25);
            this.NsyCensusLabel.TabIndex = 28;
            this.NsyCensusLabel.Text = "0";
            // 
            // PPCensusLabel
            // 
            this.PPCensusLabel.AutoSize = true;
            this.PPCensusLabel.Location = new System.Drawing.Point(248, 37);
            this.PPCensusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PPCensusLabel.Name = "PPCensusLabel";
            this.PPCensusLabel.Size = new System.Drawing.Size(24, 25);
            this.PPCensusLabel.TabIndex = 27;
            this.PPCensusLabel.Text = "0";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anticipatedDeliveryTypeDataGridViewTextBoxColumn
            // 
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.DataPropertyName = "AnticipatedDeliveryType";
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.Name = "anticipatedDeliveryTypeDataGridViewTextBoxColumn";
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn1
            // 
            this.roomDataGridViewTextBoxColumn1.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn1.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn1.Name = "roomDataGridViewTextBoxColumn1";
            this.roomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // attendingDataGridViewTextBoxColumn1
            // 
            this.attendingDataGridViewTextBoxColumn1.DataPropertyName = "Attending";
            this.attendingDataGridViewTextBoxColumn1.HeaderText = "Attending";
            this.attendingDataGridViewTextBoxColumn1.Name = "attendingDataGridViewTextBoxColumn1";
            this.attendingDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nICUDataGridViewCheckBoxColumn1
            // 
            this.nICUDataGridViewCheckBoxColumn1.DataPropertyName = "NICU";
            this.nICUDataGridViewCheckBoxColumn1.HeaderText = "NICU";
            this.nICUDataGridViewCheckBoxColumn1.Name = "nICUDataGridViewCheckBoxColumn1";
            this.nICUDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // anticipatedPatientBindingSource
            // 
            this.anticipatedPatientBindingSource.DataSource = typeof(PatientManager.Patients.AnticipatedPatient);
            // 
            // deliveredPatientBindingSource
            // 
            this.deliveredPatientBindingSource.DataSource = typeof(PatientManager.Patients.DeliveredPatient);
            // 
            // HomeToday
            // 
            this.HomeToday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HomeToday.DataPropertyName = "DischargeToday";
            this.HomeToday.FalseValue = "false";
            this.HomeToday.HeaderText = "Home";
            this.HomeToday.Name = "HomeToday";
            this.HomeToday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HomeToday.TrueValue = "true";
            this.HomeToday.Width = 74;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 113;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientTypeDataGridViewTextBoxColumn
            // 
            this.patientTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.patientTypeDataGridViewTextBoxColumn.DataPropertyName = "PatientType";
            this.patientTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.patientTypeDataGridViewTextBoxColumn.Name = "patientTypeDataGridViewTextBoxColumn";
            this.patientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientTypeDataGridViewTextBoxColumn.Width = 105;
            // 
            // nICUDataGridViewCheckBoxColumn
            // 
            this.nICUDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nICUDataGridViewCheckBoxColumn.DataPropertyName = "NICU";
            this.nICUDataGridViewCheckBoxColumn.HeaderText = "NICU";
            this.nICUDataGridViewCheckBoxColumn.Name = "nICUDataGridViewCheckBoxColumn";
            this.nICUDataGridViewCheckBoxColumn.Width = 68;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CurrentLengthOfStay";
            this.dataGridViewTextBoxColumn10.HeaderText = "LOS";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 99;
            // 
            // attendingDataGridViewTextBoxColumn
            // 
            this.attendingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.attendingDataGridViewTextBoxColumn.DataPropertyName = "Attending";
            this.attendingDataGridViewTextBoxColumn.HeaderText = "Attending";
            this.attendingDataGridViewTextBoxColumn.Name = "attendingDataGridViewTextBoxColumn";
            // 
            // acuityDataGridViewTextBoxColumn
            // 
            this.acuityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.acuityDataGridViewTextBoxColumn.DataPropertyName = "Acuity";
            this.acuityDataGridViewTextBoxColumn.HeaderText = "Acuity";
            this.acuityDataGridViewTextBoxColumn.Name = "acuityDataGridViewTextBoxColumn";
            this.acuityDataGridViewTextBoxColumn.Width = 116;
            // 
            // pIHDataGridViewCheckBoxColumn
            // 
            this.pIHDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pIHDataGridViewCheckBoxColumn.DataPropertyName = "PIH";
            this.pIHDataGridViewCheckBoxColumn.HeaderText = "PIH";
            this.pIHDataGridViewCheckBoxColumn.Name = "pIHDataGridViewCheckBoxColumn";
            this.pIHDataGridViewCheckBoxColumn.Width = 52;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2518, 1510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StaffOnShiftButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UAPListBox);
            this.Controls.Add(this.PPListBox);
            this.Controls.Add(this.NurseryListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnticipatedGrid);
            this.Controls.Add(this.DischargeButton);
            this.Controls.Add(this.DeliveredGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPatientButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "Patient Manager";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveredGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DeliveredGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLengthOfStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DischargeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn preAssignedRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView AnticipatedGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox NurseryListBox;
        private System.Windows.Forms.ListBox PPListBox;
        private System.Windows.Forms.ListBox UAPListBox;
        private System.Windows.Forms.BindingSource deliveredPatientBindingSource;
        private System.Windows.Forms.BindingSource anticipatedPatientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anticipatedDeliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nICUDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StaffOnShiftButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinNursesLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DischargesLabel;
        private System.Windows.Forms.Label NsyCensusLabel;
        private System.Windows.Forms.Label PPCensusLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HomeToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nICUDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acuityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pIHDataGridViewCheckBoxColumn;
    }
}

