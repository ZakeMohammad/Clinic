namespace cccc
{
    partial class EditPrescriptoinForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.DatePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.DatePickerStart = new System.Windows.Forms.DateTimePicker();
            this.NumberOFFrequency = new System.Windows.Forms.NumericUpDown();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.lblPersciptoinID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMedicationName = new System.Windows.Forms.TextBox();
            this.TxtSpecila = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOFFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Prescriptoin";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(315, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerEnd.Location = new System.Drawing.Point(586, 298);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.Size = new System.Drawing.Size(141, 27);
            this.DatePickerEnd.TabIndex = 28;
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerStart.Location = new System.Drawing.Point(191, 301);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.Size = new System.Drawing.Size(141, 27);
            this.DatePickerStart.TabIndex = 27;
            // 
            // NumberOFFrequency
            // 
            this.NumberOFFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOFFrequency.Location = new System.Drawing.Point(586, 208);
            this.NumberOFFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOFFrequency.Name = "NumberOFFrequency";
            this.NumberOFFrequency.Size = new System.Drawing.Size(82, 28);
            this.NumberOFFrequency.TabIndex = 26;
            this.NumberOFFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordID.Location = new System.Drawing.Point(659, 124);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(68, 22);
            this.lblMedicalRecordID.TabIndex = 23;
            this.lblMedicalRecordID.Text = "label10";
            // 
            // lblPersciptoinID
            // 
            this.lblPersciptoinID.AutoSize = true;
            this.lblPersciptoinID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersciptoinID.Location = new System.Drawing.Point(220, 124);
            this.lblPersciptoinID.Name = "lblPersciptoinID";
            this.lblPersciptoinID.Size = new System.Drawing.Size(58, 22);
            this.lblPersciptoinID.TabIndex = 22;
            this.lblPersciptoinID.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Frequency :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "End Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Medical Record ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Special Instructions :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "StartDate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Medication Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prescriptoin ID :";
            // 
            // TxtMedicationName
            // 
            this.TxtMedicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMedicationName.Location = new System.Drawing.Point(257, 209);
            this.TxtMedicationName.Name = "TxtMedicationName";
            this.TxtMedicationName.Size = new System.Drawing.Size(164, 27);
            this.TxtMedicationName.TabIndex = 29;
            // 
            // TxtSpecila
            // 
            this.TxtSpecila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSpecila.Location = new System.Drawing.Point(270, 390);
            this.TxtSpecila.Name = "TxtSpecila";
            this.TxtSpecila.Size = new System.Drawing.Size(186, 27);
            this.TxtSpecila.TabIndex = 30;
            // 
            // EditPrescriptoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 516);
            this.Controls.Add(this.TxtSpecila);
            this.Controls.Add(this.TxtMedicationName);
            this.Controls.Add(this.DatePickerEnd);
            this.Controls.Add(this.DatePickerStart);
            this.Controls.Add(this.NumberOFFrequency);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.lblPersciptoinID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditPrescriptoinForm";
            this.Text = "Edit Prescriptoin";
            this.Load += new System.EventHandler(this.EditPrescriptoinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOFFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker DatePickerEnd;
        private System.Windows.Forms.DateTimePicker DatePickerStart;
        private System.Windows.Forms.NumericUpDown NumberOFFrequency;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Label lblPersciptoinID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMedicationName;
        private System.Windows.Forms.TextBox TxtSpecila;
    }
}