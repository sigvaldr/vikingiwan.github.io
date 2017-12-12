using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace FormTest
{
    public partial class Apply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //Set variables using entered data
            var formName = name.Text;
            var formAge = age.Text;
            var formMicCheck = miccheck.SelectedValue.ToString();
            var formWhy = why.Text;
            var formRef = referrer.Text;
            //Create error var
            var errorMessage = "";
            //Email vars
            String SUBJECT = "VTAC Application";
            String BODY = "VTAC Application\n" + "Name:" + formName + "\n"
                + "Name:" + formName + "\n"
                + "Age:" + formAge + "\n"
                + "Mic Check:" + formMicCheck + "\n"
                + "Why do you want to join VTAC?:" + formWhy + "\n"
                + "Referrer:" + formRef + "\n"
                + "Sent at " + DateTime.Now;
            BODY = BODY.Replace("\n", Environment.NewLine);


            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new System.Net.Mail.MailAddress("vikingiwan@gmail.com");
            message.To.Add(new MailAddress("vikingiwan@gmail.com"));
            message.Subject = SUBJECT;
            message.Body = BODY;

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;   // [1] You can try with 465 also, I always used 587 and got success
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // [2] Added this
            smtp.UseDefaultCredentials = false; // [3] Changed this
            smtp.Credentials = new System.Net.NetworkCredential("vikingiwan@gmail.com", "pztclgbegfdzsdbi");  // [4] Added this. Note, first parameter is NOT string.
            smtp.Host = "smtp.gmail.com";


            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                errorMessage= ex.Message;
            }

            if(errorMessage == "")
            {
                ConfText.Text = "Application Submitted!";
            }
            else
            {
                ConfText.ForeColor = System.Drawing.Color.Red;
                ConfText.Text = "ERROR: Application not submitted. Please refresh and try again!" + "\n" + errorMessage;
            }
        }
    }
}