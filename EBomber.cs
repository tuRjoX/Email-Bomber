using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Email_Bomber
{
    public partial class EBomber : Form
    {
        OpenFileDialog ofdAttachment;
        string fileName = "";
        string smtpServer = "";
        int smtpPort = 0;
        bool enableSSL = false;

        public EBomber()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rbGmail.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbYahoo.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbOutlook.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGmail.Checked)
            {
                smtpServer = "smtp.gmail.com";
                smtpPort = 587;
                enableSSL = true;
            }
            else if (rbYahoo.Checked)
            {
                smtpServer = "smtp.mail.yahoo.com";
                smtpPort = 587;
                enableSSL = true;
            }
            else if (rbOutlook.Checked) // Outlook (Office 365) Settings
            {
                smtpServer = "smtp.office365.com";
                smtpPort = 587;
                enableSSL = true; // Use STARTTLS (which is enabled via SSL in .NET)
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdAttachment = new OpenFileDialog();
            ofdAttachment.Filter = "All Files (*.*)|*.*";
            ofdAttachment.Title = "Select Attachment";
            
            if (ofdAttachment.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdAttachment.FileName;
                btnBrowseFile.Text = System.IO.Path.GetFileName(fileName);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtSenderEmail.Text))
            {
                MessageBox.Show("Please enter sender email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenderPassword.Text))
            {
                MessageBox.Show("Please enter sender password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRecipientEmail.Text))
            {
                MessageBox.Show("Please enter recipient email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(smtpServer))
            {
                MessageBox.Show("Please select an email provider (Gmail, Yahoo, or Outlook).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnSend.Enabled = false;
            btnSend.Text = "Sending...";

            try
            {
                int numberOfEmails = (int)numericNo.Value;
                int delay = (int)numericUpDown1.Value;

                for (int i = 0; i < numberOfEmails; i++)
                {
                    await SendEmailAsync();
                    if (i < numberOfEmails - 1 && delay > 0)
                    {
                        await Task.Delay(delay);
                    }
                }

                MessageBox.Show($"Successfully sent {numberOfEmails} email(s)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "Send";
            }
        }

        private async Task SendEmailAsync()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(txtSenderEmail.Text);
                mail.To.Add(txtRecipientEmail.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = rtbBody.Text;
                mail.IsBodyHtml = cbxHtmlBody.Checked;
                if (!string.IsNullOrEmpty(fileName) && System.IO.File.Exists(fileName))
                {
                    Attachment attachment = new Attachment(fileName);
                    mail.Attachments.Add(attachment);
                }

                using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                {
                    smtp.Credentials = new NetworkCredential(txtSenderEmail.Text, txtSenderPassword.Text);
                    smtp.EnableSsl = enableSSL;
                    smtp.Timeout = 30000; 

                    await smtp.SendMailAsync(mail);
                }
            }
        }
    }
}
