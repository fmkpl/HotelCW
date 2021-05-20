using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class User
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public virtual Room userRoom { get; set; }

        [MaxLength(20, ErrorMessage = "Too long name.")]
        [MinLength(1, ErrorMessage = "Too short name.")]
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }


        [MaxLength(20, ErrorMessage = "Too long last name.")]
        [MinLength(1, ErrorMessage = "Too short last name.")]
        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }


        [MaxLength(30, ErrorMessage = "Too long password.")]
        [MinLength(4, ErrorMessage = "Too short password.")]
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        public int? Adults { get; set; }

        public int? ChildsUnderThree { get; set; }

        public int? ServicePrice { get; set; }

        public int? DaysInHotel { get; set; }


        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email adress.")]
        public string Email { get; set; }


        public static string HashUserPassword(string userPassword) 
        {
            //ceaser shifr
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string result = "";
            for(int i = 0; i < userPassword.Length; i++) 
            {
                for (int j = 0; j < alphabet.Length-2; j++) 
                {
                    if (userPassword[i] == 'y') 
                    {
                        result += 'a';
                    }
                    if (userPassword[i] == 'z')
                    {
                        result += 'b';
                    }
                    if (userPassword[i] == alphabet[j])
                    {
                        result += alphabet[j + 2];
                    }
                }
            }
            for(int i = 0; i < userPassword.Length; i++) 
            {
                for (int j = 0; j < digits.Length-2; j++) 
                {
                    if (userPassword[i] == '9') 
                    {
                        result += '1';
                    }
                    if (userPassword[i] == '0')
                    {
                        result += '2';
                    }
                    if (userPassword[i] == digits[j])
                    {
                        result += digits[j + 2];
                    }
                }
            }
            return result;
        }
        
    }
}
