using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using Control_Aulas_UAM.Clases.Db;

namespace Control_Aulas_UAM.Clases
{
    static class Email
    {

        public static void send(Usuario origen,Usuario destino,Alerta alerta)
        {
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            //mensaje
            try
            {
                m.From = new MailAddress("espacios@uam.net.ni", "Reservacion-EspaciosUAM");
                m.To.Add(new MailAddress(destino.Email, destino.Nombre));
                m.CC.Add(new MailAddress(origen.Email,origen.Nombre));
                m.Subject = "Reservación de Espacio";
                m.IsBodyHtml = true;
                m.Body = "Reservación";

                string str = "<html><body><h1>Informe de Reservación</h1><h2>Este es un correo generado automáticamente para notificar la reservación realizadas en EspaciosUAM.Favor no responder a este correo si no a los destinatarios </h2>" +
                "<br/>Aula:" + alerta.Aula.Referencia +
                "<br/>Fecha Inicio:" + alerta.FechaEvento +
                "<br/>FechaFin:" + alerta.FechaRecordatorio +
                "<br/>Decripción:" + alerta.Descripcion +
                "<br/>Observaciónes:" + alerta.Observaciones+
                "<br/>Estado:" + alerta.DescripcionEstado+
                "<br/><br/>Origen:" + origen.Nombre+
                "<br/>Destino:"+destino.Nombre
                + "</body></html>";

                AlternateView av = AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
                m.AlternateViews.Add(av);

                sc.Host = "Pod51011.outlook.com";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("espacios@uam.net.ni", "siga2siga");
                sc.EnableSsl = true;
                sc.Send(m);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
 
    }
}
