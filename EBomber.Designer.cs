namespace Email_Bomber
{
    partial class EBomber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EBomber));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenderPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxHtmlBody = new System.Windows.Forms.CheckBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbOutlook = new System.Windows.Forms.RadioButton();
            this.rbYahoo = new System.Windows.Forms.RadioButton();
            this.rbGmail = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSenderPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSenderEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(156, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "(Use App Password)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.Location = new System.Drawing.Point(159, 62);
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.PasswordChar = '*';
            this.txtSenderPassword.Size = new System.Drawing.Size(277, 26);
            this.txtSenderPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail :";
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(159, 27);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(277, 26);
            this.txtSenderEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRecipientEmail);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipient Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Recipient E-mail :";
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Location = new System.Drawing.Point(159, 39);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(277, 26);
            this.txtRecipientEmail.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.numericNo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 408);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 69);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ms";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(272, 31);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(72, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delay :";
            // 
            // numericNo
            // 
            this.numericNo.Location = new System.Drawing.Point(151, 31);
            this.numericNo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNo.Name = "numericNo";
            this.numericNo.ReadOnly = true;
            this.numericNo.Size = new System.Drawing.Size(56, 26);
            this.numericNo.TabIndex = 1;
            this.numericNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number of Mail :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbBody);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 483);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 120);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(8, 22);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbBody.Size = new System.Drawing.Size(428, 92);
            this.rtbBody.TabIndex = 1;
            this.rtbBody.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxHtmlBody);
            this.groupBox3.Controls.Add(this.txtSubject);
            this.groupBox3.Controls.Add(this.btnBrowseFile);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 123);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-mail Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subject :";
            // 
            // cbxHtmlBody
            // 
            this.cbxHtmlBody.AutoSize = true;
            this.cbxHtmlBody.Location = new System.Drawing.Point(159, 94);
            this.cbxHtmlBody.Name = "cbxHtmlBody";
            this.cbxHtmlBody.Size = new System.Drawing.Size(101, 24);
            this.cbxHtmlBody.TabIndex = 2;
            this.cbxHtmlBody.Text = "Html Body";
            this.cbxHtmlBody.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(159, 28);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(277, 26);
            this.txtSubject.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(159, 59);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(118, 29);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "File Attachment :";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(146, 609);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 42);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbOutlook);
            this.groupBox6.Controls.Add(this.rbYahoo);
            this.groupBox6.Controls.Add(this.rbGmail);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 129);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(442, 57);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Type";
            // 
            // rbOutlook
            // 
            this.rbOutlook.AutoSize = true;
            this.rbOutlook.Location = new System.Drawing.Point(295, 25);
            this.rbOutlook.Name = "rbOutlook";
            this.rbOutlook.Size = new System.Drawing.Size(82, 24);
            this.rbOutlook.TabIndex = 2;
            this.rbOutlook.TabStop = true;
            this.rbOutlook.Text = "Outlook";
            this.rbOutlook.UseVisualStyleBackColor = true;
            // 
            // rbYahoo
            // 
            this.rbYahoo.AutoSize = true;
            this.rbYahoo.Location = new System.Drawing.Point(186, 25);
            this.rbYahoo.Name = "rbYahoo";
            this.rbYahoo.Size = new System.Drawing.Size(74, 24);
            this.rbYahoo.TabIndex = 1;
            this.rbYahoo.TabStop = true;
            this.rbYahoo.Text = "Yahoo";
            this.rbYahoo.UseVisualStyleBackColor = true;
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Location = new System.Drawing.Point(71, 25);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(68, 24);
            this.rbGmail.TabIndex = 0;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            // 
            // EBomber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 660);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EBomber";
            this.Text = "Email Bomber";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenderPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxHtmlBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericNo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbOutlook;
        private System.Windows.Forms.RadioButton rbYahoo;
        private System.Windows.Forms.RadioButton rbGmail;
        private System.Windows.Forms.Label label9;
    }
}

