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
            this.label1 = new System.Windows.Forms.Label();
            this.CCLcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RNcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NSYcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCTcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddToShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCL";
            // 
            // CCLcheckedListBox
            // 
            this.CCLcheckedListBox.FormattingEnabled = true;
            this.CCLcheckedListBox.Location = new System.Drawing.Point(72, 113);
            this.CCLcheckedListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CCLcheckedListBox.Name = "CCLcheckedListBox";
            this.CCLcheckedListBox.Size = new System.Drawing.Size(368, 160);
            this.CCLcheckedListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Postpartum";
            // 
            // RNcheckedListBox
            // 
            this.RNcheckedListBox.FormattingEnabled = true;
            this.RNcheckedListBox.Location = new System.Drawing.Point(72, 392);
            this.RNcheckedListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RNcheckedListBox.Name = "RNcheckedListBox";
            this.RNcheckedListBox.Size = new System.Drawing.Size(368, 914);
            this.RNcheckedListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nursery";
            // 
            // NSYcheckedListBox
            // 
            this.NSYcheckedListBox.FormattingEnabled = true;
            this.NSYcheckedListBox.Location = new System.Drawing.Point(798, 113);
            this.NSYcheckedListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NSYcheckedListBox.Name = "NSYcheckedListBox";
            this.NSYcheckedListBox.Size = new System.Drawing.Size(368, 160);
            this.NSYcheckedListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PCTs / HUAs";
            // 
            // PCTcheckedListBox
            // 
            this.PCTcheckedListBox.FormattingEnabled = true;
            this.PCTcheckedListBox.Location = new System.Drawing.Point(798, 392);
            this.PCTcheckedListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PCTcheckedListBox.Name = "PCTcheckedListBox";
            this.PCTcheckedListBox.Size = new System.Drawing.Size(368, 472);
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
            // FormStaffOnShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1377);
            this.Controls.Add(this.AddToShift);
            this.Controls.Add(this.PCTcheckedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NSYcheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RNcheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CCLcheckedListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormStaffOnShift";
            this.Text = "Scheduled Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CCLcheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox RNcheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox NSYcheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox PCTcheckedListBox;
        private System.Windows.Forms.Button AddToShift;
    }
}