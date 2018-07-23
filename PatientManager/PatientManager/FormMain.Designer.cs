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
            this.Home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnticipatedGrid = new System.Windows.Forms.DataGridView();
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
            this.AddPatientButton.Location = new System.Drawing.Point(917, 631);
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
            this.label1.Location = new System.Drawing.Point(40, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
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
            this.DeliveredGrid.Location = new System.Drawing.Point(32, 34);
            this.DeliveredGrid.Name = "DeliveredGrid";
            this.DeliveredGrid.Size = new System.Drawing.Size(918, 490);
            this.DeliveredGrid.TabIndex = 7;
            // 
            // DischargeButton
            // 
            this.DischargeButton.Location = new System.Drawing.Point(916, 566);
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
            // Home
            // 
            this.Home.HeaderText = "H";
            this.Home.Name = "Home";
            this.Home.Width = 25;
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
            this.AnticipatedGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnticipatedGrid_CellContentDoubleClick);
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
            this.Controls.Add(this.AnticipatedGrid);
            this.Controls.Add(this.DischargeButton);
            this.Controls.Add(this.DeliveredGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPatientButton);
            this.Name = "FormMain";
            this.Text = "Patient Manager";
            this.Activated += new System.EventHandler(this.Form1_Activated);
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
    }
}

