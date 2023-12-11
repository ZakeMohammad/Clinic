namespace cccc
{
    partial class AddNewPaymentForm
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
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ComboForPaymentMethod = new System.Windows.Forms.ComboBox();
            this.DatePickerForPayment = new System.Windows.Forms.DateTimePicker();
            this.NumberOfAmountPaid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAmountPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount Paid :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment Method :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "?????";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(186, 458);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(289, 87);
            this.TxtNotes.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ComboForPaymentMethod
            // 
            this.ComboForPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboForPaymentMethod.FormattingEnabled = true;
            this.ComboForPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Bank transfers",
            "Mobile payments",
            "Credit Cards"});
            this.ComboForPaymentMethod.Location = new System.Drawing.Point(186, 385);
            this.ComboForPaymentMethod.Name = "ComboForPaymentMethod";
            this.ComboForPaymentMethod.Size = new System.Drawing.Size(168, 24);
            this.ComboForPaymentMethod.TabIndex = 9;
            // 
            // DatePickerForPayment
            // 
            this.DatePickerForPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerForPayment.Location = new System.Drawing.Point(154, 212);
            this.DatePickerForPayment.Name = "DatePickerForPayment";
            this.DatePickerForPayment.Size = new System.Drawing.Size(128, 22);
            this.DatePickerForPayment.TabIndex = 10;
            // 
            // NumberOfAmountPaid
            // 
            this.NumberOfAmountPaid.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfAmountPaid.Location = new System.Drawing.Point(154, 300);
            this.NumberOfAmountPaid.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfAmountPaid.Name = "NumberOfAmountPaid";
            this.NumberOfAmountPaid.Size = new System.Drawing.Size(64, 22);
            this.NumberOfAmountPaid.TabIndex = 11;
            this.NumberOfAmountPaid.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AddNewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 635);
            this.Controls.Add(this.NumberOfAmountPaid);
            this.Controls.Add(this.DatePickerForPayment);
            this.Controls.Add(this.ComboForPaymentMethod);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAmountPaid)).EndInit();
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
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ComboForPaymentMethod;
        private System.Windows.Forms.DateTimePicker DatePickerForPayment;
        private System.Windows.Forms.NumericUpDown NumberOfAmountPaid;
    }
}