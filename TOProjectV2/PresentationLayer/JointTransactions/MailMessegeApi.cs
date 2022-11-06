using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.JointTransactions
{
    public class MailMessegeApi
    {
        public void Microsoft(string SenderNameSurname, string SenderMail, string SenderPass, string BuyerMail, string Title, string Contents, string extra)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(SenderMail, SenderPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(SenderMail, SenderNameSurname);
            mail.To.Add(BuyerMail);
            mail.Subject = Title;
            mail.IsBodyHtml = true;
            mail.Body = Contents;
            try
            {
                if (extra != null)
                {
                    mail.Attachments.Add(new Attachment(extra));
                }
            }
            catch (Exception)
            {
            }
            
            // sc.Timeout = 100;//BURADA BİR HATA VERİYOR ZAMANLAMAYLA İLGİLİ KALDIRILDI
            sc.Send(mail);
        }
        public void Google(string SenderNameSurname, string SenderMail, string SenderPass, string BuyerMail, string Title, string Contents, string extra)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(SenderMail, SenderPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(SenderMail, SenderNameSurname);
            mail.To.Add(BuyerMail);
            mail.Subject = Title;
            mail.IsBodyHtml = true;
            mail.Body = Contents;
            if (extra != null)
            {
                mail.Attachments.Add(new Attachment(extra));
            }
            sc.Timeout = 100;
            sc.Send(mail);
        }
    }
}
