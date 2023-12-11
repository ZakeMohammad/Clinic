namespace cccc
{
    partial class AppointmentsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.ctrlPersonInfo1 = new cccc.ctrlPersonInfo();
            this.ctrlPatientInfo1 = new cccc.ctrlPatientInfo();
            this.btnNextForPatient = new System.Windows.Forms.Button();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.ctrlDoctorInfo1 = new cccc.ctrlDoctorInfo();
            this.btnSelectForDoctor = new System.Windows.Forms.Button();
            this.btnNextForDoctor = new System.Windows.Forms.Button();
            this.ctrlPersonInfo2 = new cccc.ctrlPersonInfo();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.DatePickerForAppoinments = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxForStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            this.Page3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Controls.Add(this.Page2);
            this.tabControl1.Controls.Add(this.Page3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1334, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.ctrlPersonInfo1);
            this.Page1.Controls.Add(this.ctrlPatientInfo1);
            this.Page1.Controls.Add(this.btnNextForPatient);
            this.Page1.Controls.Add(this.btnSelectPatient);
            this.Page1.Location = new System.Drawing.Point(4, 27);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(1326, 660);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Select Patient";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(9, 60);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.PersonID = 0;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(975, 295);
            this.ctrlPersonInfo1.TabIndex = 7;
            // 
            // ctrlPatientInfo1
            // 
            this.ctrlPatientInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPatientInfo1.Location = new System.Drawing.Point(9, 378);
            this.ctrlPatientInfo1.Name = "ctrlPatientInfo1";
            this.ctrlPatientInfo1.Size = new System.Drawing.Size(975, 169);
            this.ctrlPatientInfo1.TabIndex = 6;
            // 
            // btnNextForPatient
            // 
            this.btnNextForPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextForPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextForPatient.Location = new System.Drawing.Point(818, 15);
            this.btnNextForPatient.Name = "btnNextForPatient";
            this.btnNextForPatient.Size = new System.Drawing.Size(166, 39);
            this.btnNextForPatient.TabIndex = 4;
            this.btnNextForPatient.Text = "Next";
            this.btnNextForPatient.UseVisualStyleBackColor = true;
            this.btnNextForPatient.Click += new System.EventHandler(this.btnNextForPatient_Click);
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPatient.Location = new System.Drawing.Point(551, 15);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(166, 39);
            this.btnSelectPatient.TabIndex = 3;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.UseVisualStyleBackColor = true;
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.ctrlDoctorInfo1);
            this.Page2.Controls.Add(this.btnSelectForDoctor);
            this.Page2.Controls.Add(this.btnNextForDoctor);
            this.Page2.Controls.Add(this.ctrlPersonInfo2);
            this.Page2.Location = new System.Drawing.Point(4, 27);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(1326, 660);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Select Doctor";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // ctrlDoctorInfo1
            // 
            this.ctrlDoctorInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDoctorInfo1.Location = new System.Drawing.Point(8, 382);
            this.ctrlDoctorInfo1.Name = "ctrlDoctorInfo1";
            this.ctrlDoctorInfo1.Size = new System.Drawing.Size(954, 157);
            this.ctrlDoctorInfo1.TabIndex = 8;
            // 
            // btnSelectForDoctor
            // 
            this.btnSelectForDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectForDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectForDoctor.Location = new System.Drawing.Point(578, 26);
            this.btnSelectForDoctor.Name = "btnSelectForDoctor";
            this.btnSelectForDoctor.Size = new System.Drawing.Size(166, 39);
            this.btnSelectForDoctor.TabIndex = 7;
            this.btnSelectForDoctor.Text = "Select Doctor";
            this.btnSelectForDoctor.UseVisualStyleBackColor = true;
            this.btnSelectForDoctor.Click += new System.EventHandler(this.btnSelectForDoctor_Click);
            // 
            // btnNextForDoctor
            // 
            this.btnNextForDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextForDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextForDoctor.Location = new System.Drawing.Point(796, 26);
            this.btnNextForDoctor.Name = "btnNextForDoctor";
            this.btnNextForDoctor.Size = new System.Drawing.Size(166, 39);
            this.btnNextForDoctor.TabIndex = 5;
            this.btnNextForDoctor.Text = "Next";
            this.btnNextForDoctor.UseVisualStyleBackColor = true;
            this.btnNextForDoctor.Click += new System.EventHandler(this.btnNextForDoctor_Click);
            // 
            // ctrlPersonInfo2
            // 
            this.ctrlPersonInfo2.BackColor = System.Drawing.Color.White;
            this.ctrlPersonInfo2.Location = new System.Drawing.Point(8, 65);
            this.ctrlPersonInfo2.Name = "ctrlPersonInfo2";
            this.ctrlPersonInfo2.PersonID = 0;
            this.ctrlPersonInfo2.Size = new System.Drawing.Size(954, 295);
            this.ctrlPersonInfo2.TabIndex = 6;
            // 
            // Page3
            // 
            this.Page3.Controls.Add(this.btnClose);
            this.Page3.Controls.Add(this.btnSave);
            this.Page3.Controls.Add(this.btnPay);
            this.Page3.Controls.Add(this.DatePickerForAppoinments);
            this.Page3.Controls.Add(this.ComboBoxForStatus);
            this.Page3.Controls.Add(this.label3);
            this.Page3.Controls.Add(this.label2);
            this.Page3.Controls.Add(this.label1);
            this.Page3.Location = new System.Drawing.Point(4, 27);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(1326, 660);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Appointments Detelis";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(629, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(442, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(203, 315);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(126, 29);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // DatePickerForAppoinments
            // 
            this.DatePickerForAppoinments.CustomFormat = "";
            this.DatePickerForAppoinments.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerForAppoinments.Location = new System.Drawing.Point(262, 190);
            this.DatePickerForAppoinments.Name = "DatePickerForAppoinments";
            this.DatePickerForAppoinments.Size = new System.Drawing.Size(123, 24);
            this.DatePickerForAppoinments.TabIndex = 5;
            // 
            // ComboBoxForStatus
            // 
            this.ComboBoxForStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxForStatus.FormattingEnabled = true;
            this.ComboBoxForStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Canceled",
            "Rescheduled",
            "No Show"});
            this.ComboBoxForStatus.Location = new System.Drawing.Point(175, 78);
            this.ComboBoxForStatus.Name = "ComboBoxForStatus";
            this.ComboBoxForStatus.Size = new System.Drawing.Size(176, 26);
            this.ComboBoxForStatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appoinment Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status :";
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 691);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentsForm";
            this.Tag = "Appointments";
            this.Text = "AppointmentsForm";
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page2.ResumeLayout(false);
            this.Page3.ResumeLayout(false);
            this.Page3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.TabPage Page3;
        private ctrlPatientInfo ctrlPatientInfo1;
        private System.Windows.Forms.Button btnNextForPatient;
        private System.Windows.Forms.Button btnSelectPatient;
        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlDoctorInfo ctrlDoctorInfo1;
        private System.Windows.Forms.Button btnSelectForDoctor;
        private ctrlPersonInfo ctrlPersonInfo2;
        private System.Windows.Forms.Button btnNextForDoctor;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DateTimePicker DatePickerForAppoinments;
        private System.Windows.Forms.ComboBox ComboBoxForStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}