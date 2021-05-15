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
            MailAddress fromMailAddress = new MailAddress("efimberg22@gmail.com", "Administrator " + AdminName);
            MailAddress toAddress = new MailAddress(client.Email,"Dear, " + client.Name + " " + client.LastName);


            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Accept";
                mailMessage.Body = $"Your room number is {client.userRoom.Number}. Price to pay = {client.ServicePrice}$\nWelcome to the hotel!\nAny questions? - Visit reception.\nYou can also leave a review after log-in in registration window.\nHave a good stay! =)";

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
            MailAddress fromMailAddress = new MailAddress("efimberg22@gmail.com", "Administrator " + AdminName);
            MailAddress toAddress = new MailAddress(client.Email, "Dear, " + client.Name + " " + client.LastName);


            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Eviction";
                mailMessage.Body = $"You were evicted from {client.userRoom.Number} room. Any questions? - Visit reception.\nYou can also leave a review after log-in in registration window.\nWe were glad to see you in our hotel!";

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
