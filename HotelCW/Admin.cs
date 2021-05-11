using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;

namespace HotelCW
{
    public class Admin
    {
        public int Id { get; set; }


        [MaxLength(30, ErrorMessage = "Too long name.")]
        [MinLength(2, ErrorMessage = "Too short name.")]
        [Required(ErrorMessage = "This field is required.")]
        public string AdminName { get; set; }


        [MaxLength(30, ErrorMessage = "Too long password.")]
        [MinLength(4,ErrorMessage = "Too short password.")]
        [Required(ErrorMessage = "This field is required.")]
        public string AdminPassword { get; set; }


        [MaxLength(20, ErrorMessage = "Too long control word.")]
        [MinLength(4, ErrorMessage = "Too short control word.")]
        [Required(ErrorMessage = "This field is required.")]
        public string AdminControlword { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public void AcceptRoomReserving() { }
        public void CancelRoomReserving() { }

        public void SendEmailToClient(User client) 
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("efimberg22@gmail.com", AdminName);
            // кому отправляем
            MailAddress to = new MailAddress(client.Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Accept";
            // текст письма
            m.Body = $"<h2>Your room number is {client.userRoom.Number}.</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("efimberg22@gmail.com", "LLW-XNG-Nny-3Gw");
            smtp.EnableSsl = true;
            smtp.Send(m);

        }

    }
}
