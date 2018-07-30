﻿namespace PatientManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliveredGrid = new System.Windows.Forms.DataGridView();
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
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deliveredPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DischargeButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnticipatedGrid = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICUDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anticipatedPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EditAnticipatedButton = new System.Windows.Forms.Button();
            this.StaffOnShiftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinNursesLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DischargesLabel = new System.Windows.Forms.Label();
            this.NsyCensusLabel = new System.Windows.Forms.Label();
            this.PPCensusLabel = new System.Windows.Forms.Label();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pPRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pPAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveredGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPAssignmentBindingSource)).BeginInit();
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
            this.pIHDataGridViewCheckBoxColumn,
            this.Column1});
            this.DeliveredGrid.DataSource = this.deliveredPatientBindingSource;
            this.DeliveredGrid.Location = new System.Drawing.Point(64, 94);
            this.DeliveredGrid.Margin = new System.Windows.Forms.Padding(6);
            this.DeliveredGrid.Name = "DeliveredGrid";
            this.DeliveredGrid.Size = new System.Drawing.Size(1836, 942);
            this.DeliveredGrid.TabIndex = 7;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roomDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "CurrentNurse";
            this.Column1.HeaderText = "Nurse";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deliveredPatientBindingSource
            // 
            this.deliveredPatientBindingSource.AllowNew = true;
            this.deliveredPatientBindingSource.DataSource = typeof(PatientManager.Patients.DeliveredPatient);
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
            this.DayLabel.Location = new System.Drawing.Point(810, 17);
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
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1998, 490);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nursery Staff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1998, 94);
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
            // EditAnticipatedButton
            // 
            this.EditAnticipatedButton.Location = new System.Drawing.Point(1366, 1254);
            this.EditAnticipatedButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditAnticipatedButton.Name = "EditAnticipatedButton";
            this.EditAnticipatedButton.Size = new System.Drawing.Size(236, 102);
            this.EditAnticipatedButton.TabIndex = 27;
            this.EditAnticipatedButton.Text = "Edit Anticipated / Change to Delivered";
            this.EditAnticipatedButton.UseVisualStyleBackColor = true;
            this.EditAnticipatedButton.Click += new System.EventHandler(this.EditAnticipatedButton_Click);
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
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "CurrentNurse";
            this.dataGridViewComboBoxColumn1.HeaderText = "Nurse";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.assignmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pPAssignmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2003, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(344, 206);
            this.dataGridView1.TabIndex = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nurse";
            this.Column2.HeaderText = "Nurse";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 114;
            // 
            // assignmentDataGridViewTextBoxColumn
            // 
            this.assignmentDataGridViewTextBoxColumn.DataPropertyName = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.DataSource = this.pPRolesBindingSource;
            this.assignmentDataGridViewTextBoxColumn.HeaderText = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.Name = "assignmentDataGridViewTextBoxColumn";
            this.assignmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.assignmentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.assignmentDataGridViewTextBoxColumn.Width = 169;
            // 
            // pPRolesBindingSource
            // 
            this.pPRolesBindingSource.DataSource = typeof(PatientManager.Shifts.Shift.PPRoles);
            // 
            // pPAssignmentBindingSource
            // 
            this.pPAssignmentBindingSource.DataSource = typeof(PatientManager.Shifts.PPAssignment);
            // 
            // nurseDataGridViewTextBoxColumn
            // 
            this.nurseDataGridViewTextBoxColumn.DataPropertyName = "Nurse";
            this.nurseDataGridViewTextBoxColumn.HeaderText = "Nurse";
            this.nurseDataGridViewTextBoxColumn.Name = "nurseDataGridViewTextBoxColumn";
            this.nurseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nurseDataGridViewTextBoxColumn.Width = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2518, 1510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StaffOnShiftButton);
            this.Controls.Add(this.EditAnticipatedButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPAssignmentBindingSource)).EndInit();
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
        private System.Windows.Forms.Button EditAnticipatedButton;
        private System.Windows.Forms.Button StaffOnShiftButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinNursesLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DischargesLabel;
        private System.Windows.Forms.Label NsyCensusLabel;
        private System.Windows.Forms.Label PPCensusLabel;
        private System.Windows.Forms.BindingSource deliveredPatientBindingSource;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn assignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pPRolesBindingSource;
        private System.Windows.Forms.BindingSource pPAssignmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseDataGridViewTextBoxColumn;
    }
}

