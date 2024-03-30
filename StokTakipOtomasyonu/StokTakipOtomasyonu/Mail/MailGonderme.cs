using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using StokTakipOtomasyonu.DataAccessLayer.ComplexType;

namespace StokTakipOtomasyonu.Mail
{
    public class MailGonderme
    {

        public class MusteriMailGonderme
        {
            public void Mesaj(string Baslik, string icerik, string mail)
            {
                MailMessage message = new MailMessage();



                message.From = new MailAddress("gorselfinal@gmail.com");//Kimden
                message.To.Add(mail); //kime
                message.Subject = Baslik;
                message.Body = icerik;


                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("gorselfinal@gmail.com", "201103019Ahmet");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com"; //outlok için
                istemci.EnableSsl = true; //Doğru adrese ulaşana kadar şifreleme yapması


                istemci.Send(message);




            }

        }


        public class AdminMailGonderme
        {

            public void AdminMesaj(string Baslik, string icerik) //Uygulama İçerisinden Admine Gidicek Bilgilendirmeleri Tutucak olan İnner Class
            {
                MailMessage message = new MailMessage();



                message.From = new MailAddress("gorselfinal@gmail.com");//Kimden

                AdminMailleri mailler = new AdminMailleri();

                foreach (var item in mailler.GetAdminMailleri()) //Adminler Ekleniyor
                {
                    message.To.Add(item.AdminmailAdres); //kime
                }

             
                message.Subject = Baslik;
                message.Body = icerik;


                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("gorselfinal@gmail.com", "201103019Ahmet");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com"; //outlok için
                istemci.EnableSsl = true; //Doğru adrese ulaşana kadar şifreleme yapması


                istemci.Send(message);




            }
        }


        public class PersonelMailGonderme
        {

            public void PersonelMesaj(string Baslik, string icerik) 
            {
                MailMessage message = new MailMessage();



                message.From = new MailAddress("gorselfinal@gmail.com");//Kimden

                PersonelMailleri mailler = new PersonelMailleri();

                foreach (var item in mailler.GetPersonelMailleri()) //Personl Mailleri Ekleniyor
                {
                    message.To.Add(item.PersonelMialler); //kime
                }


                message.Subject = Baslik;
                message.Body = icerik;


                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("gorselfinal@gmail.com", "201103019Ahmet");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com"; //outlok için
                istemci.EnableSsl = true; //Doğru adrese ulaşana kadar şifreleme yapması


                istemci.Send(message);




            }
        }
    }
}
