namespace PatientManager
{
    partial class FormAddPatient
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
            this.AddButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.anticipatedRadio = new System.Windows.Forms.RadioButton();
            this.deliveredRadio = new System.Windows.Forms.RadioButton();
            this.typeGroup = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.Label();
            this.DeliveryGroup = new System.Windows.Forms.GroupBox();
            this.gynButton = new System.Windows.Forms.RadioButton();
            this.csRadio = new System.Windows.Forms.RadioButton();
            this.vagRadio = new System.Windows.Forms.RadioButton();
            this.delivDate = new System.Windows.Forms.Label();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nonEngCheck = new System.Windows.Forms.CheckBox();
            this.confidCheck = new System.Windows.Forms.CheckBox();
            this.pihCheck = new System.Windows.Forms.CheckBox();
            this.medicaidCheck = new System.Windows.Forms.CheckBox();
            this.nicuCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendingBox = new System.Windows.Forms.TextBox();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeGroup.SuspendLayout();
            this.DeliveryGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(530, 364);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Patient";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(31, 364);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // anticipatedRadio
            // 
            this.anticipatedRadio.AutoSize = true;
            this.anticipatedRadio.Location = new System.Drawing.Point(19, 11);
            this.anticipatedRadio.Name = "anticipatedRadio";
            this.anticipatedRadio.Size = new System.Drawing.Size(78, 17);
            this.anticipatedRadio.TabIndex = 2;
            this.anticipatedRadio.Text = "Anticipated";
            this.anticipatedRadio.UseVisualStyleBackColor = true;
            this.anticipatedRadio.CheckedChanged += new System.EventHandler(this.anticipatedRadio_CheckedChanged);
            // 
            // deliveredRadio
            // 
            this.deliveredRadio.AutoSize = true;
            this.deliveredRadio.Location = new System.Drawing.Point(19, 33);
            this.deliveredRadio.Name = "deliveredRadio";
            this.deliveredRadio.Size = new System.Drawing.Size(70, 17);
            this.deliveredRadio.TabIndex = 3;
            this.deliveredRadio.Text = "Delivered";
            this.deliveredRadio.UseVisualStyleBackColor = true;
            // 
            // typeGroup
            // 
            this.typeGroup.Controls.Add(this.deliveredRadio);
            this.typeGroup.Controls.Add(this.anticipatedRadio);
            this.typeGroup.Location = new System.Drawing.Point(12, 7);
            this.typeGroup.Name = "typeGroup";
            this.typeGroup.Size = new System.Drawing.Size(136, 57);
            this.typeGroup.TabIndex = 4;
            this.typeGroup.TabStop = false;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(31, 81);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 5;
            this.lastName.Text = "Last Name";
            // 
            // nameBox
            // 
            this.nameBox.AcceptsTab = true;
            this.nameBox.Location = new System.Drawing.Point(106, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(145, 20);
            this.nameBox.TabIndex = 0;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(31, 145);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(69, 13);
            this.Room.TabIndex = 7;
            this.Room.Text = "Assign Room";
            // 
            // DeliveryGroup
            // 
            this.DeliveryGroup.Controls.Add(this.gynButton);
            this.DeliveryGroup.Controls.Add(this.csRadio);
            this.DeliveryGroup.Controls.Add(this.vagRadio);
            this.DeliveryGroup.Location = new System.Drawing.Point(35, 182);
            this.DeliveryGroup.Name = "DeliveryGroup";
            this.DeliveryGroup.Size = new System.Drawing.Size(216, 94);
            this.DeliveryGroup.TabIndex = 9;
            this.DeliveryGroup.TabStop = false;
            this.DeliveryGroup.Text = "Patient Type";
            // 
            // gynButton
            // 
            this.gynButton.AutoSize = true;
            this.gynButton.Location = new System.Drawing.Point(26, 65);
            this.gynButton.Name = "gynButton";
            this.gynButton.Size = new System.Drawing.Size(48, 17);
            this.gynButton.TabIndex = 2;
            this.gynButton.TabStop = true;
            this.gynButton.Text = "GYN";
            this.gynButton.UseVisualStyleBackColor = true;
            // 
            // csRadio
            // 
            this.csRadio.AutoSize = true;
            this.csRadio.Location = new System.Drawing.Point(27, 42);
            this.csRadio.Name = "csRadio";
            this.csRadio.Size = new System.Drawing.Size(44, 17);
            this.csRadio.TabIndex = 1;
            this.csRadio.TabStop = true;
            this.csRadio.Text = "C/S";
            this.csRadio.UseVisualStyleBackColor = true;
            // 
            // vagRadio
            // 
            this.vagRadio.AutoSize = true;
            this.vagRadio.Location = new System.Drawing.Point(27, 19);
            this.vagRadio.Name = "vagRadio";
            this.vagRadio.Size = new System.Drawing.Size(44, 17);
            this.vagRadio.TabIndex = 3;
            this.vagRadio.TabStop = true;
            this.vagRadio.Text = "Vag";
            this.vagRadio.UseVisualStyleBackColor = true;
            // 
            // delivDate
            // 
            this.delivDate.AutoSize = true;
            this.delivDate.Location = new System.Drawing.Point(35, 288);
            this.delivDate.Name = "delivDate";
            this.delivDate.Size = new System.Drawing.Size(112, 13);
            this.delivDate.TabIndex = 10;
            this.delivDate.Text = "Delivery/Surgery Date";
            // 
            // deliveryDate
            // 
            this.deliveryDate.CustomFormat = "M/d/yy      HH:mm";
            this.deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryDate.Location = new System.Drawing.Point(38, 304);
            this.deliveryDate.MinDate = new System.DateTime(2018, 7, 12, 0, 0, 0, 0);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(162, 20);
            this.deliveryDate.TabIndex = 3;
            this.deliveryDate.Value = new System.DateTime(2018, 7, 23, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nonEngCheck);
            this.groupBox2.Controls.Add(this.confidCheck);
            this.groupBox2.Controls.Add(this.pihCheck);
            this.groupBox2.Controls.Add(this.medicaidCheck);
            this.groupBox2.Controls.Add(this.nicuCheck);
            this.groupBox2.Location = new System.Drawing.Point(378, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 302);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // nonEngCheck
            // 
            this.nonEngCheck.AutoSize = true;
            this.nonEngCheck.Location = new System.Drawing.Point(30, 132);
            this.nonEngCheck.Name = "nonEngCheck";
            this.nonEngCheck.Size = new System.Drawing.Size(107, 17);
            this.nonEngCheck.TabIndex = 11;
            this.nonEngCheck.Text = "Language Barrier";
            this.nonEngCheck.UseVisualStyleBackColor = true;
            // 
            // confidCheck
            // 
            this.confidCheck.AutoSize = true;
            this.confidCheck.Location = new System.Drawing.Point(30, 108);
            this.confidCheck.Name = "confidCheck";
            this.confidCheck.Size = new System.Drawing.Size(81, 17);
            this.confidCheck.TabIndex = 10;
            this.confidCheck.Text = "Confidential";
            this.confidCheck.UseVisualStyleBackColor = true;
            // 
            // pihCheck
            // 
            this.pihCheck.AutoSize = true;
            this.pihCheck.Location = new System.Drawing.Point(30, 84);
            this.pihCheck.Name = "pihCheck";
            this.pihCheck.Size = new System.Drawing.Size(44, 17);
            this.pihCheck.TabIndex = 9;
            this.pihCheck.Text = "PIH";
            this.pihCheck.UseVisualStyleBackColor = true;
            // 
            // medicaidCheck
            // 
            this.medicaidCheck.AutoSize = true;
            this.medicaidCheck.Location = new System.Drawing.Point(30, 60);
            this.medicaidCheck.Name = "medicaidCheck";
            this.medicaidCheck.Size = new System.Drawing.Size(69, 17);
            this.medicaidCheck.TabIndex = 8;
            this.medicaidCheck.Text = "Medicaid";
            this.medicaidCheck.UseVisualStyleBackColor = true;
            // 
            // nicuCheck
            // 
            this.nicuCheck.AutoSize = true;
            this.nicuCheck.Location = new System.Drawing.Point(30, 36);
            this.nicuCheck.Name = "nicuCheck";
            this.nicuCheck.Size = new System.Drawing.Size(52, 17);
            this.nicuCheck.TabIndex = 7;
            this.nicuCheck.Text = "NICU";
            this.nicuCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Attending";
            // 
            // AttendingBox
            // 
            this.AttendingBox.AcceptsTab = true;
            this.AttendingBox.Location = new System.Drawing.Point(106, 112);
            this.AttendingBox.Name = "AttendingBox";
            this.AttendingBox.Size = new System.Drawing.Size(145, 20);
            this.AttendingBox.TabIndex = 1;
            // 
            // roomBox
            // 
            this.roomBox.AllowDrop = true;
            this.roomBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.roomBindingSource, "RoomNumber", true));
            this.roomBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomNumber", true));
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(141, 142);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(110, 21);
            this.roomBox.TabIndex = 2;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(PatientManager.Patients.Room);
            // 
            // FormAddPatient
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(631, 418);
            this.Controls.Add(this.AttendingBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.delivDate);
            this.Controls.Add(this.DeliveryGroup);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.typeGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddButton);
            this.Name = "FormAddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.typeGroup.ResumeLayout(false);
            this.typeGroup.PerformLayout();
            this.DeliveryGroup.ResumeLayout(false);
            this.DeliveryGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton anticipatedRadio;
        private System.Windows.Forms.RadioButton deliveredRadio;
        private System.Windows.Forms.GroupBox typeGroup;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.GroupBox DeliveryGroup;
        private System.Windows.Forms.RadioButton gynButton;
        private System.Windows.Forms.RadioButton csRadio;
        private System.Windows.Forms.RadioButton vagRadio;
        private System.Windows.Forms.Label delivDate;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nonEngCheck;
        private System.Windows.Forms.CheckBox confidCheck;
        private System.Windows.Forms.CheckBox pihCheck;
        private System.Windows.Forms.CheckBox medicaidCheck;
        private System.Windows.Forms.CheckBox nicuCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AttendingBox;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.BindingSource roomBindingSource;
        public System.Windows.Forms.Button AddButton;
    }
}