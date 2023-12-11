namespace cccc
{
    partial class EditAppointmentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddMedecalRecord = new System.Windows.Forms.Button();
            this.ComboForStates = new System.Windows.Forms.ComboBox();
            this.DatePaickerForAppointments = new System.Windows.Forms.DateTimePicker();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddNewPayment = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Statues :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Appointments Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Add Medical Record:";
            // 
            // btnAddMedecalRecord
            // 
            this.btnAddMedecalRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedecalRecord.Location = new System.Drawing.Point(820, 121);
            this.btnAddMedecalRecord.Name = "btnAddMedecalRecord";
            this.btnAddMedecalRecord.Size = new System.Drawing.Size(116, 33);
            this.btnAddMedecalRecord.TabIndex = 7;
            this.btnAddMedecalRecord.Text = "Add";
            this.btnAddMedecalRecord.UseVisualStyleBackColor = true;
            this.btnAddMedecalRecord.Click += new System.EventHandler(this.btnAddMedecalRecord_Click);
            // 
            // ComboForStates
            // 
            this.ComboForStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboForStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboForStates.FormattingEnabled = true;
            this.ComboForStates.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Canceled",
            "Rescheduled",
            "No Show"});
            this.ComboForStates.Location = new System.Drawing.Point(415, 126);
            this.ComboForStates.Name = "ComboForStates";
            this.ComboForStates.Size = new System.Drawing.Size(165, 24);
            this.ComboForStates.TabIndex = 8;
            this.ComboForStates.SelectedIndexChanged += new System.EventHandler(this.ComboForStates_SelectedIndexChanged);
            // 
            // DatePaickerForAppointments
            // 
            this.DatePaickerForAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePaickerForAppointments.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePaickerForAppointments.Location = new System.Drawing.Point(506, 205);
            this.DatePaickerForAppointments.Name = "DatePaickerForAppointments";
            this.DatePaickerForAppointments.Size = new System.Drawing.Size(133, 24);
            this.DatePaickerForAppointments.TabIndex = 9;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(185, 127);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(54, 20);
            this.lblDoctorID.TabIndex = 10;
            this.lblDoctorID.Text = "?????";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(185, 209);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(54, 20);
            this.lblPatientID.TabIndex = 11;
            this.lblPatientID.Text = "?????";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(185, 290);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(54, 20);
            this.lblPaymentID.TabIndex = 12;
            this.lblPaymentID.Text = "?????";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(348, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(542, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 39);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordID.Location = new System.Drawing.Point(882, 207);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(54, 20);
            this.lblMedicalRecordID.TabIndex = 16;
            this.lblMedicalRecordID.Text = "?????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(699, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Medical Record ID:";
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPayment.Location = new System.Drawing.Point(511, 285);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(116, 33);
            this.btnAddNewPayment.TabIndex = 18;
            this.btnAddNewPayment.Text = "Add";
            this.btnAddNewPayment.UseVisualStyleBackColor = true;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add New Payment:";
            // 
            // EditAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 439);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.DatePaickerForAppointments);
            this.Controls.Add(this.ComboForStates);
            this.Controls.Add(this.btnAddMedecalRecord);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Appointments";
            this.Load += new System.EventHandler(this.EditAppointmentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddMedecalRecord;
        private System.Windows.Forms.ComboBox ComboForStates;
        private System.Windows.Forms.DateTimePicker DatePaickerForAppointments;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNewPayment;
        private System.Windows.Forms.Label label8;
    }
}