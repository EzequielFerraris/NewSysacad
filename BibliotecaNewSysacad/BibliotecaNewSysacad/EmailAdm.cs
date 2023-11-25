using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public static class EmailAdm
    {
         
        static EmailAdm() { }

        private static SmtpClient Cliente(string origen, string pass)
        {
            var SmtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(origen, pass),
                EnableSsl = true,
            };
            return SmtpClient; 
        }

        public static void EnviarEmail(string destinatario, string asunto, string cuerpo) 
        {
            string from = "newsysacad@gmail.com";
            string pass = "nrgsumtrctnvvmhh";


            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress(from);
            mensaje.Subject = asunto;
            mensaje.To.Add(new MailAddress(destinatario));
            mensaje.Body = cuerpo;
            mensaje.IsBodyHtml = false;

            var cliente = Cliente(from, pass);

            try
            {
                cliente.Send(mensaje);
            }
            catch (Exception)
            {
                throw;
            }
        
        }
    }
}
