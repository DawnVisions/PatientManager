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
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliveredGrid = new System.Windows.Forms.DataGridView();
            this.Home = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PreviousButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CCLListBox = new System.Windows.Forms.ListBox();
            this.NurseryListBox = new System.Windows.Forms.ListBox();
            this.PPListBox = new System.Windows.Forms.ListBox();
            this.UAPListBox = new System.Windows.Forms.ListBox();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preAssignedRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anticipatedPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acuityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICUDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pIHDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medicaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveredPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveredGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(683, 581);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(118, 53);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anticipated Patients";
            // 
            // DeliveredGrid
            // 
            this.DeliveredGrid.AutoGenerateColumns = false;
            this.DeliveredGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveredGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Home,
            this.Room,
            this.lastNameDataGridViewTextBoxColumn,
            this.PatientType,
            this.attendingDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.acuityDataGridViewTextBoxColumn,
            this.nICUDataGridViewCheckBoxColumn,
            this.pIHDataGridViewCheckBoxColumn,
            this.medicaidDataGridViewCheckBoxColumn});
            this.DeliveredGrid.DataSource = this.deliveredPatientBindingSource;
            this.DeliveredGrid.Location = new System.Drawing.Point(32, 49);
            this.DeliveredGrid.Name = "DeliveredGrid";
            this.DeliveredGrid.Size = new System.Drawing.Size(918, 490);
            this.DeliveredGrid.TabIndex = 7;
            // 
            // Home
            // 
            this.Home.HeaderText = "H";
            this.Home.Name = "Home";
            this.Home.Width = 25;
            // 
            // DischargeButton
            // 
            this.DischargeButton.Location = new System.Drawing.Point(831, 581);
            this.DischargeButton.Name = "DischargeButton";
            this.DischargeButton.Size = new System.Drawing.Size(119, 55);
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
            this.preAssignedRoomDataGridViewTextBoxColumn,
            this.attendingDataGridViewTextBoxColumn1});
            this.AnticipatedGrid.DataSource = this.anticipatedPatientBindingSource;
            this.AnticipatedGrid.Location = new System.Drawing.Point(32, 583);
            this.AnticipatedGrid.Name = "AnticipatedGrid";
            this.AnticipatedGrid.ReadOnly = true;
            this.AnticipatedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnticipatedGrid.Size = new System.Drawing.Size(443, 150);
            this.AnticipatedGrid.TabIndex = 9;
            this.AnticipatedGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnticipatedGrid_CellDoubleClick);
            this.AnticipatedGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AnticipatedGrid_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Family Suites";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(505, 9);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(132, 20);
            this.DayLabel.TabIndex = 11;
            this.DayLabel.Text = "Monday July 23rd";
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftLabel.Location = new System.Drawing.Point(643, 9);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(45, 20);
            this.ShiftLabel.TabIndex = 12;
            this.ShiftLabel.Text = "Days";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(726, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next Shift";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(400, 9);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 15;
            this.PreviousButton.Text = "Previous Shift";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nursery Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(999, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Clinical Care Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(999, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Postpartum Staff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unlicensed Staff";
            // 
            // CCLListBox
            // 
            this.CCLListBox.FormattingEnabled = true;
            this.CCLListBox.Location = new System.Drawing.Point(1002, 65);
            this.CCLListBox.Name = "CCLListBox";
            this.CCLListBox.Size = new System.Drawing.Size(159, 30);
            this.CCLListBox.TabIndex = 20;
            // 
            // NurseryListBox
            // 
            this.NurseryListBox.FormattingEnabled = true;
            this.NurseryListBox.Location = new System.Drawing.Point(1002, 126);
            this.NurseryListBox.Name = "NurseryListBox";
            this.NurseryListBox.Size = new System.Drawing.Size(159, 82);
            this.NurseryListBox.TabIndex = 21;
            // 
            // PPListBox
            // 
            this.PPListBox.FormattingEnabled = true;
            this.PPListBox.Location = new System.Drawing.Point(1002, 238);
            this.PPListBox.Name = "PPListBox";
            this.PPListBox.Size = new System.Drawing.Size(159, 186);
            this.PPListBox.TabIndex = 22;
            // 
            // UAPListBox
            // 
            this.UAPListBox.FormattingEnabled = true;
            this.UAPListBox.Location = new System.Drawing.Point(1002, 463);
            this.UAPListBox.Name = "UAPListBox";
            this.UAPListBox.Size = new System.Drawing.Size(159, 43);
            this.UAPListBox.TabIndex = 23;
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
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.HeaderText = "Anticipated Type";
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.Name = "anticipatedDeliveryTypeDataGridViewTextBoxColumn";
            this.anticipatedDeliveryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preAssignedRoomDataGridViewTextBoxColumn
            // 
            this.preAssignedRoomDataGridViewTextBoxColumn.DataPropertyName = "PreAssignedRoom";
            this.preAssignedRoomDataGridViewTextBoxColumn.HeaderText = "Pre-Assigned Room";
            this.preAssignedRoomDataGridViewTextBoxColumn.Name = "preAssignedRoomDataGridViewTextBoxColumn";
            this.preAssignedRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendingDataGridViewTextBoxColumn1
            // 
            this.attendingDataGridViewTextBoxColumn1.DataPropertyName = "Attending";
            this.attendingDataGridViewTextBoxColumn1.HeaderText = "Attending";
            this.attendingDataGridViewTextBoxColumn1.Name = "attendingDataGridViewTextBoxColumn1";
            this.attendingDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anticipatedPatientBindingSource
            // 
            this.anticipatedPatientBindingSource.DataSource = typeof(PatientManager.Patients.AnticipatedPatient);
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PatientType
            // 
            this.PatientType.DataPropertyName = "PatientType";
            this.PatientType.HeaderText = "Type";
            this.PatientType.Name = "PatientType";
            this.PatientType.ReadOnly = true;
            this.PatientType.Width = 50;
            // 
            // attendingDataGridViewTextBoxColumn
            // 
            this.attendingDataGridViewTextBoxColumn.DataPropertyName = "Attending";
            this.attendingDataGridViewTextBoxColumn.HeaderText = "Attending";
            this.attendingDataGridViewTextBoxColumn.Name = "attendingDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // acuityDataGridViewTextBoxColumn
            // 
            this.acuityDataGridViewTextBoxColumn.DataPropertyName = "Acuity";
            this.acuityDataGridViewTextBoxColumn.HeaderText = "Acuity";
            this.acuityDataGridViewTextBoxColumn.Name = "acuityDataGridViewTextBoxColumn";
            // 
            // nICUDataGridViewCheckBoxColumn
            // 
            this.nICUDataGridViewCheckBoxColumn.DataPropertyName = "NICU";
            this.nICUDataGridViewCheckBoxColumn.HeaderText = "NICU";
            this.nICUDataGridViewCheckBoxColumn.Name = "nICUDataGridViewCheckBoxColumn";
            // 
            // pIHDataGridViewCheckBoxColumn
            // 
            this.pIHDataGridViewCheckBoxColumn.DataPropertyName = "PIH";
            this.pIHDataGridViewCheckBoxColumn.HeaderText = "PIH";
            this.pIHDataGridViewCheckBoxColumn.Name = "pIHDataGridViewCheckBoxColumn";
            // 
            // medicaidDataGridViewCheckBoxColumn
            // 
            this.medicaidDataGridViewCheckBoxColumn.DataPropertyName = "Medicaid";
            this.medicaidDataGridViewCheckBoxColumn.HeaderText = "Medicaid";
            this.medicaidDataGridViewCheckBoxColumn.Name = "medicaidDataGridViewCheckBoxColumn";
            this.medicaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deliveredPatientBindingSource
            // 
            this.deliveredPatientBindingSource.AllowNew = false;
            this.deliveredPatientBindingSource.DataSource = typeof(PatientManager.Patients.DeliveredPatient);
            this.deliveredPatientBindingSource.Sort = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 785);
            this.Controls.Add(this.UAPListBox);
            this.Controls.Add(this.PPListBox);
            this.Controls.Add(this.NurseryListBox);
            this.Controls.Add(this.CCLListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnticipatedGrid);
            this.Controls.Add(this.DischargeButton);
            this.Controls.Add(this.DeliveredGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPatientButton);
            this.Name = "FormMain";
            this.Text = "Patient Manager";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveredGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnticipatedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anticipatedPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredPatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DeliveredGrid;
        public System.Windows.Forms.BindingSource deliveredPatientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLengthOfStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DischargeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Home;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acuityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nICUDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pIHDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn medicaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anticipatedDeliveryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preAssignedRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource anticipatedPatientBindingSource;
        private System.Windows.Forms.DataGridView AnticipatedGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox CCLListBox;
        private System.Windows.Forms.ListBox NurseryListBox;
        private System.Windows.Forms.ListBox PPListBox;
        private System.Windows.Forms.ListBox UAPListBox;
    }
}

