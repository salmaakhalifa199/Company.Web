using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email input)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("salma.sherif1992003@gmail.com", "gqjmbvmqktwaorqe");

            client.Send("salma.sherif1992003@gmail.com" , input.To,input.Subject,input.Body);
            // from = "salma.sherif1992003@gmail.com"
        }
        // smtp da protocol bnshtghdmo 34an nagem el gmail (ab3t email)
    }
}
