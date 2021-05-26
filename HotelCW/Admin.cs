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


        [MaxLength(30, ErrorMessage = "Слишком длинное имя.")]
        [MinLength(2, ErrorMessage = "Слишком короткое имя.")]
        [Required(ErrorMessage = "Это поле обязательно.")]
        public string AdminName { get; set; }


        [MaxLength(30, ErrorMessage = "Слишком длинный пароль.")]
        [MinLength(4,ErrorMessage = "Слишком короткий пароль.")]
        [Required(ErrorMessage = "Это поле обязательно.")]
        public string AdminPassword { get; set; }


        [MaxLength(20, ErrorMessage = "Слишком длинное ключевое слово.")]
        [MinLength(4, ErrorMessage = "Слишком короткое ключевое слово.")]
        [Required(ErrorMessage = "Это поле обязательно.")]
        public string AdminControlword { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public void AcceptRoomReserving() { }
        public void CancelRoomReserving() { }

        public void SendEmailToClient(User client) 
        {
            MailAddress fromMailAddress = new MailAddress("efimberg22@gmail.com", "Администратор " + AdminName);
            MailAddress toAddress = new MailAddress(client.Email,"Уважаемый, " + client.Name + " " + client.LastName);


            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Подтверждение";
                mailMessage.Body = $"Ваш номер - №{client.userRoom.Number}." +
                    $"\nСумма к оплате = {client.ServicePrice.ToString()}$." +
                    $"\nВаши контактные данные: {client.PhoneNumber.ToString()}, { client.Email.ToString()}." +
                    $"\nВы будете проживать в отеле на протяжении: {client.DaysInHotel.ToString()} суток." +
                    $"\nКол-во взрослых в номере: {client.Adults.ToString()}, кол-во детей до 3 лет: {client.ChildsUnderThree.ToString()}." +
                    $"\nДобро пожаловать в отель!\nВозникли вопросы? - Обращайтесь в ресепшн.\nТакже вы можете оставить свой отзыв после процесса авторизации в окне регистрации.";

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "LLW-XNG-Nny-3Gw");

                smtpClient.Send(mailMessage);
            }

        }

        public void SendEmailAboutEviction(User client) 
        {
            MailAddress fromMailAddress = new MailAddress("efimberg22@gmail.com", "Администратор " + AdminName);
            MailAddress toAddress = new MailAddress(client.Email, "Уважаемый, " + client.Name + " " + client.LastName);


            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Выселение";
                mailMessage.Body = $"Вас выселили из номера {client.userRoom.Number}. Возникли вопросы? - Обращайтесь в ресепшн.\nТакже вы можете оставить свой отзыв после процесса авторизации в окне регистрации.\nРады были вас видеть в нашем отеле!";

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "LLW-XNG-Nny-3Gw");

                smtpClient.Send(mailMessage);
            }

        }
    }
}
