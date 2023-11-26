using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ONION_PROJECT.APPLICATION.Services.EmailServices
{
    public class EmailService:IEmailService
    {
        public async Task SendMail(string head,  string content,string MailAdresi)
        {
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential("info@insight-hr.online", "PassHR_34790");
            // mail göndermek için oturum açtık

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();//email adresi eklecek); // yeni mail oluşturduk
            mail.From = new System.Net.Mail.MailAddress("info@insight-hr.online"); // maili gönderecek hesabı belirttik
            mail.To.Add(MailAdresi); // mail gönderilecek adres
            mail.Subject = head; // mailin konusu
            mail.Body = content;
            mail.IsBodyHtml = true;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("mail.kurumsaleposta.com", 587); // smtp servere bağlandık
            smtp.EnableSsl = false; // ssl kullanımına izin verdik
            smtp.Credentials = cred; // server üzerindeki oturumumuzu yukarıda belirttiğimiz NetworkCredential üzerinden sağladık.
            
            
          await  smtp.SendMailAsync(mail); // mailimizi gönderdik.
                             // smtp yani Simple Mail Transfer Protocol üzerinden maili gönderiyoruz.
        }
    }
}
