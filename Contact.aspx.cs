﻿using System;

using System.Net.Mail;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("gvgjc012@gmail.com");
                mailMessage.To.Add("gvgjc012@gmail.com");
                mailMessage.Subject = Subject.Text;

                mailMessage.Body = "<b>Sender Name : </b>" + Name.Text + "</br>"
                    + "<b>Sender Email : </b>" + Email.Text + "< br/>"
                    + "<b>Comments : </b>" + Message.Text;
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new
                    System.Net.NetworkCredential("gvgjc012@gmail.com", "123456jc1");
                smtpClient.Send(mailMessage);

                Label1.ForeColor = System.Drawing.Color.Blue;
                Label1.Text = "We appreciate your feedback and will be reviewed";

                Name.Enabled = false;
                Email.Enabled = false;
                Message.Enabled = false;
                Subject.Enabled = false;
                Button1.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            // Log the exception information to 
            // database table or event viewer
            Label1.ForeColor = System.Drawing.Color.Blue;
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "There is an unkwon problem. Please try later";
        }

    }
}