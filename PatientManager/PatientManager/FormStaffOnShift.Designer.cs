namespace PatientManager
{
    partial class FormStaffOnShift
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NSYcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCTcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddToShift = new System.Windows.Forms.Button();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RNCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Postpartum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nursery";
            // 
            // NSYcheckedListBox
            // 
            this.NSYcheckedListBox.FormattingEnabled = true;
            this.NSYcheckedListBox.Location = new System.Drawing.Point(517, 106);
            this.NSYcheckedListBox.Margin = new System.Windows.Forms.Padding(6);
            this.NSYcheckedListBox.Name = "NSYcheckedListBox";
            this.NSYcheckedListBox.Size = new System.Drawing.Size(368, 784);
            this.NSYcheckedListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PCTs / HUAs";
            // 
            // PCTcheckedListBox
            // 
            this.PCTcheckedListBox.FormattingEnabled = true;
            this.PCTcheckedListBox.Location = new System.Drawing.Point(985, 106);
            this.PCTcheckedListBox.Margin = new System.Windows.Forms.Padding(6);
            this.PCTcheckedListBox.Name = "PCTcheckedListBox";
            this.PCTcheckedListBox.Size = new System.Drawing.Size(368, 784);
            this.PCTcheckedListBox.TabIndex = 7;
            // 
            // AddToShift
            // 
            this.AddToShift.Location = new System.Drawing.Point(1055, 1178);
            this.AddToShift.Name = "AddToShift";
            this.AddToShift.Size = new System.Drawing.Size(201, 101);
            this.AddToShift.TabIndex = 8;
            this.AddToShift.Text = "Add Staff";
            this.AddToShift.UseVisualStyleBackColor = true;
            this.AddToShift.Click += new System.EventHandler(this.AddToShift_Click);
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(PatientManager.Staff.Nurse);
            // 
            // nurseBindingSource1
            // 
            this.nurseBindingSource1.DataSource = typeof(PatientManager.Staff.Nurse);
            // 
            // RNCheckedListBox
            // 
            this.RNCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nurseBindingSource, "Name", true));
            this.RNCheckedListBox.FormattingEnabled = true;
            this.RNCheckedListBox.Location = new System.Drawing.Point(72, 106);
            this.RNCheckedListBox.Name = "RNCheckedListBox";
            this.RNCheckedListBox.Size = new System.Drawing.Size(350, 1044);
            this.RNCheckedListBox.TabIndex = 9;
            // 
            // FormStaffOnShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1436, 1377);
            this.Controls.Add(this.RNCheckedListBox);
            this.Controls.Add(this.AddToShift);
            this.Controls.Add(this.PCTcheckedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NSYcheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStaffOnShift";
            this.Text = "Scheduled Staff";
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox NSYcheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox PCTcheckedListBox;
        private System.Windows.Forms.Button AddToShift;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.BindingSource nurseBindingSource1;
        private System.Windows.Forms.CheckedListBox RNCheckedListBox;
    }
}