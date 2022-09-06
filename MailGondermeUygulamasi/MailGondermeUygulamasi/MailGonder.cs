﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailGondermeUygulamasi
{
    public class MailGonder
    {
        public void Microsoft(string GondericiAdSoyad, string GondericiMail, string GondericiPass, string AliciMail, string Baslik, string icerik, string ek)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, GondericiAdSoyad);
            mail.To.Add(AliciMail);
            mail.Subject = Baslik;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            if (ek != null)
            {
                mail.Attachments.Add(new Attachment(ek));
            }
           // sc.Timeout = 100;//BURADA BİR HATA VERİYOR ZAMANLAMAYLA İLGİLİ KALDIRILDI
            sc.Send(mail);
        }
        public void Google(string GondericiAdSoyad, string GondericiMail, string GondericiPass, string AliciMail, string Baslik, string icerik, string ek)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, GondericiAdSoyad);
            mail.To.Add(AliciMail);
            mail.Subject = Baslik;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            if (ek != null)
            {
                mail.Attachments.Add(new Attachment(ek));
            }
            sc.Timeout = 100;
            sc.Send(mail);

        }
    }
}
