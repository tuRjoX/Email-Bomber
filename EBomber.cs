using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;

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
            // Attach event handlers to radio buttons
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

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
